namespace Rad301August2017.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Rad301August2017.Models.AttendenceModel.AttendDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Rad301August2017.Models.AttendenceModel.AttendDBContext context)
        {
            #region Roles
            var Lecturer =
                new UserManager<ApplicationUser>(
                    new UserStore<ApplicationUser>(context));

            var roleManager =
                new RoleManager<IdentityRole>(
                    new RoleStore<IdentityRole>(context));

            roleManager.Create(new IdentityRole { Name = "Lecturer" });
            roleManager.Create(new IdentityRole { Name = "Student" });
            #endregion

            //Did not have sufficient time to finish adding User Roles, here is an example of what it might look like though
            //context.Users.AddOrUpdate(u => u.Email, new ApplicationUser
            //{
            //    Id = "ppowell",
            //    Email = "powell.paul@itsligo.ie",
            //    UserName = "powell.paul@itsligo.ie",
            //    PasswordHash = new PasswordHasher().HashPassword("Ppowell$1"),
            //    SecurityStamp = Guid.NewGuid().ToString(),
            //    EmailConfirmed = true
            //});

        }
    }
}
