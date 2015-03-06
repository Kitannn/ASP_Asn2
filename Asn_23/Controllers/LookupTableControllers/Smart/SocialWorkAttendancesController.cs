using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Asn_23.Models;

namespace Asn_23.Controllers.LookupTableControllers.Smart
{
    [Authorize(Roles = "Administrator")]
    public class SocialWorkAttendancesController : Controller
    {
        private GoodSamaritanContext db = new GoodSamaritanContext();

        // GET: SocialWorkAttendances
        public ActionResult Index()
        {
            return View(db.SocialWorkAttendances.ToList());
        }

        // GET: SocialWorkAttendances/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SocialWorkAttendance socialWorkAttendance = db.SocialWorkAttendances.Find(id);
            if (socialWorkAttendance == null)
            {
                return HttpNotFound();
            }
            return View(socialWorkAttendance);
        }

        // GET: SocialWorkAttendances/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SocialWorkAttendances/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SocialWorkAttendanceId,YesNoNA")] SocialWorkAttendance socialWorkAttendance)
        {
            if (ModelState.IsValid)
            {
                db.SocialWorkAttendances.Add(socialWorkAttendance);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(socialWorkAttendance);
        }

        // GET: SocialWorkAttendances/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SocialWorkAttendance socialWorkAttendance = db.SocialWorkAttendances.Find(id);
            if (socialWorkAttendance == null)
            {
                return HttpNotFound();
            }
            return View(socialWorkAttendance);
        }

        // POST: SocialWorkAttendances/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SocialWorkAttendanceId,YesNoNA")] SocialWorkAttendance socialWorkAttendance)
        {
            if (ModelState.IsValid)
            {
                db.Entry(socialWorkAttendance).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(socialWorkAttendance);
        }

        // GET: SocialWorkAttendances/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SocialWorkAttendance socialWorkAttendance = db.SocialWorkAttendances.Find(id);
            if (socialWorkAttendance == null)
            {
                return HttpNotFound();
            }
            return View(socialWorkAttendance);
        }

        // POST: SocialWorkAttendances/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SocialWorkAttendance socialWorkAttendance = db.SocialWorkAttendances.Find(id);
            db.SocialWorkAttendances.Remove(socialWorkAttendance);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
