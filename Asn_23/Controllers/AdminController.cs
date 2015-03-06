using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity.EntityFramework;
using Asn_23.Models;
using System.Web.Security;
using Microsoft.AspNet.Identity;

namespace Asn_23.Controllers
{
    [Authorize(Roles="Administrator")]
    public class AdminController : Controller
    {
        // Redirect default to Roles
        public ActionResult Index()
        {
            return RedirectToAction("Roles");
        }

        // GET: Admin/ManageRoles
        public ActionResult ManageRoles()
        {
            return View();
        }

        // GET: Admin/ManageUsers
        public ActionResult ManageUsers()
        {
            return View();
        }

        // GET: Admin
        public ActionResult Roles()
        {
            if (TempData.ContainsKey("Message"))
            {
                ViewBag.Message = TempData["Message"];
            }
            ViewBag.Users = GetUsersList();
            ViewBag.Roles = GetRolesList();
            return View();
        }

        [HttpPost]
        public ActionResult AddRole()
        {
            string userid = Request.Form["Users"];
            string role = Request.Form["Roles"];
            // If either is null, function was accessed directly
            if (userid == null || role == null)
            { return RedirectToAction("Roles"); }

            var context = new ApplicationDbContext();
            var RoleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            string username = UserManager.FindById(userid).Email;
            IList<string> roles = UserManager.GetRoles(userid);
            if (!roles.Contains(role)) // User is not already in the role being assigned
            {
                UserManager.AddToRole(userid, role);
                TempData["Message"] = String.Format("User {0} has been added to role {1}", username, role);
            }
            else
            {
                TempData["Message"] = String.Format("User {0} already exists in role {1}", username, role);
            }
            return RedirectToAction("Roles");
        }

        public ActionResult Remove()
        {
            if (TempData.ContainsKey("Message"))
            {
                ViewBag.Message = TempData["Message"];
            }
            ViewBag.Users = GetUsersList();
            return View("RemoveRole1");
        }

        public ActionResult RemoveChooseRole()
        {
            if (Request.Form["Users"] == null)
            {
                return RedirectToAction("Remove");
            }
            string userid = Request.Form["Users"];
            ViewBag.UserId = userid;
            ViewBag.Roles = GetRolesById(userid);
            return View("RemoveRole2");
        }

        [HttpPost]
        public ActionResult RemoveRole()
        {
            string userid = Request.Form["userid"];
            string role = Request.Form["Roles"];
            
            // If either is null, this function was accessed directly
            if (userid == null || role == null)
            {
                return RedirectToAction("Remove");
            }

            string username = GetUsernameById(userid);
            // Check if it is attempting to remove last Administrator
            if (role == "Administrator")
            {
                if (isLastAdmin())
                {
                    TempData["Message"] = String.Format("Cannot remove user {0} from role {1} because " +
                                            "he or she is the last Administrator", username, role);
                    return RedirectToAction("Remove");
                }
            }
            
            // Begin remove user from role
            var context = new ApplicationDbContext();
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            UserManager.RemoveFromRole(userid, role);
            TempData["Message"] = String.Format("User {0} has been removed from role {1}", username, role);

            return RedirectToAction("Remove");
        }

        private List<SelectListItem> GetUsersList()
        {
            var context = new ApplicationDbContext();
            var users = from c in context.Users
                        select c;
            List<SelectListItem> usersSL = new List<SelectListItem>();
            foreach (var user in users)
            {
                usersSL.Add(new SelectListItem { Text = user.Email, Value = user.Id });
            }
            return usersSL;
        }

        private List<SelectListItem> GetUnsuspendedUsersList()
        {
            var context = new ApplicationDbContext();
            var users =
                from c in context.Users
                where c.LockoutEnabled == true
                where ((c.LockoutEndDateUtc <= DateTime.Now) || (c.LockoutEndDateUtc == null))
                select new { c.Email, c.Id };

            List<SelectListItem> usersSL = new List<SelectListItem>();
            foreach (var user in users)
            {
                usersSL.Add(new SelectListItem { Text = user.Email, Value = user.Id });
            }
            return usersSL;
        }

        private List<SelectListItem> GetSuspendedUsersList()
        {
            var context = new ApplicationDbContext();
            var users =
                from c in context.Users
                where c.LockoutEnabled == true
                where c.LockoutEndDateUtc > DateTime.Now
                select new { c.Email, c.Id };

            List<SelectListItem> usersSL = new List<SelectListItem>();
            foreach (var user in users)
            {
                usersSL.Add(new SelectListItem { Text = user.Email, Value = user.Id });
            }
            return usersSL;
        }

        private List<SelectListItem> GetRolesList()
        {
            var context = new ApplicationDbContext();

            var roles = (from c in context.Roles
                         select new { c.Name }).Select(m => m.Name).ToList();



            List<SelectListItem> rolesSL = new List<SelectListItem>();
            foreach (string role in roles)
            {
                rolesSL.Add(new SelectListItem { Text = role, Value = role });
            }
            return rolesSL;
        }

        private List<SelectListItem> GetRolesById(string userid)
        {
            var context = new ApplicationDbContext();
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            
            IList<string> roles = UserManager.GetRoles(userid);
            List<SelectListItem> rolesSL = new List<SelectListItem>();
            foreach(var role in roles)
            {
                rolesSL.Add(new SelectListItem { Text = role });
            }
            return rolesSL;
        }

        private string GetUsernameById(string userId)
        {
            var context = new ApplicationDbContext();
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            return UserManager.FindById(userId).Email;
        }

        private bool isLastAdmin()
        {
            var context = new ApplicationDbContext();
            var RoleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            int num = RoleManager.FindByName("Administrator").Users.Count();
            if(num == 1)
            {
                return true;
            }
            return false;
        }

        public ActionResult Suspend()
        {
            if (TempData.ContainsKey("Message"))
            {
                ViewBag.Message = TempData["Message"];
            }

            var context = new ApplicationDbContext();

            // Get users who have lockout enabled and are not currently suspended
            List<SelectListItem> usersSL = GetUnsuspendedUsersList();
            ViewBag.Users = usersSL;

            return View();
        }

        [HttpPost]
        public ActionResult SuspendUser()
        {
            // get username from post and create UserManager
            string userid = Request.Form["Users"];

            if (userid == null)
            {
                TempData["Message"] = String.Format("User selected was null");
                return RedirectToAction("Suspend");
            }

            var context = new ApplicationDbContext();
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            // Set LockoutEndDate to an ureasonable date in the future
            // to suspend the selected user indefinitely
            DateTime dt = new DateTime(5000, 01, 01);
            DateTimeOffset dto = new DateTimeOffset(dt);
            UserManager.SetLockoutEndDate(userid, dto);

            string username = GetUsernameById(userid);

            // add message to tempdata and requery for unsuspended users
            TempData["Message"] = String.Format("User {0} has been suspended", username);
            List<SelectListItem> usersSL = GetUnsuspendedUsersList();
            ViewBag.Users = usersSL;

            return RedirectToAction("Suspend");
        }

        public ActionResult Unsuspend()
        {
            if (TempData.ContainsKey("Message"))
            {
                ViewBag.Message = TempData["Message"];
            }

            var context = new ApplicationDbContext();

            // Get users who have lockout enabled and are currently suspended
            List<SelectListItem> usersSL = GetSuspendedUsersList();
            ViewBag.Users = usersSL;

            return View();
        }

        [HttpPost]
        public ActionResult UnsuspendUser()
        {
            // get username from post and create UserManager
            string userid = Request.Form["Users"];

            if (userid == null)
            {
                TempData["Message"] = String.Format("User selected was null");
                return RedirectToAction("Unsuspend");
            }

            var context = new ApplicationDbContext();
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            // Set LockoutEndDate to the a DateTime value in the past
            // to unsuspend a user
            DateTime dt = new DateTime(2000, 01, 01);
            DateTimeOffset dto = new DateTimeOffset(dt);
            UserManager.SetLockoutEndDateAsync(userid, dto);

            string username = GetUsernameById(userid);

            // set message and re-query for suspended users
            TempData["Message"] = String.Format("User {0} has been unsuspended", username);
            List<SelectListItem> usersSL = GetSuspendedUsersList();
            ViewBag.Users = usersSL;

            return RedirectToAction("Unsuspend");
        }
    }


}