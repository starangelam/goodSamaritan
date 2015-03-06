namespace GoodSamaritan.Migrations.IdentityMigration
{
    using GoodSamaritan.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GoodSamaritan.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\IdentityMigration";
        }

        protected override void Seed(GoodSamaritan.Models.ApplicationDbContext context)
        {
            // create roles: administrator, worker, reporter
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            if (!roleManager.RoleExists("Administrator"))
                roleManager.Create(new IdentityRole("Administrator"));

            if (!roleManager.RoleExists("Worker"))
                roleManager.Create(new IdentityRole("Worker"));

            if (!roleManager.RoleExists("Reporter"))
                roleManager.Create(new IdentityRole("Reporter"));

            // create users
            string email;
            string password = "P@$$w0rd";
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            email = "adam@gs.ca";
            if (!(context.Users.Any(u => u.UserName == email)))
            {
                ApplicationUser userToInsert = new ApplicationUser { UserName = email, Email = email };
                userManager.Create(userToInsert, password);
                userManager.AddToRole(userToInsert.Id, "Administrator");
            }

            email = "wendy@gs.ca";
            if (!(context.Users.Any(u => u.UserName == email)))
            {
                ApplicationUser userToInsert = new ApplicationUser { UserName = email, Email = email };
                userManager.Create(userToInsert, password);
                userManager.AddToRole(userToInsert.Id, "Worker");
            }

            email = "rob@gs.ca";
            if (!(context.Users.Any(u => u.UserName == email)))
            {
                ApplicationUser userToInsert = new ApplicationUser { UserName = email, Email = email };
                userManager.Create(userToInsert, password);
                userManager.AddToRole(userToInsert.Id, "Reporter");
            }
        }
    }
}
