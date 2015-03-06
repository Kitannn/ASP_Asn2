namespace Asn_23.Migrations.Users
{
    using Asn_23.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Asn_23.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\Users";
        }

        protected override void Seed(Asn_23.Models.ApplicationDbContext context)
        {
            var RoleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            RoleManager.Create(new IdentityRole("Administrator"));
            RoleManager.Create(new IdentityRole("Worker"));
            RoleManager.Create(new IdentityRole("Reporter"));

            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var User = new ApplicationUser() { UserName = "adam@gs.ca", Email = "adam@gs.ca", LockoutEnabled = false };
            var Result = UserManager.Create(User, "P@$$w0rd");
            UserManager.AddToRole(User.Id, "Administrator");

            User = new ApplicationUser() { UserName = "wendy@gs.ca", Email = "wendy@gs.ca", LockoutEnabled = true };
            Result = UserManager.Create(User, "P@$$w0rd");
            UserManager.AddToRole(User.Id, "Worker");

            User = new ApplicationUser() { UserName = "rob@gs.ca", Email = "rob@gs.ca", LockoutEnabled = true };
            Result = UserManager.Create(User, "P@$$w0rd");
            UserManager.AddToRole(User.Id, "Reporter");
        }
    }
}
