namespace eManager.Web.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Web.Security;

    internal sealed class Configuration : DbMigrationsConfiguration<Infrastructure.DepartmentDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Infrastructure.DepartmentDb context)
        {
            context.Departments.AddOrUpdate(d => d.Name,
                        new Domain.Department() { Name = "Engineering" },
                        new Domain.Department() { Name = "Sales" },
                        new Domain.Department() { Name = "Shipping" },
                        new Domain.Department() { Name = "Human Resources" }
                    );

            if (!Roles.RoleExists("Admin"))
            {
                Roles.CreateRole("Admin");
            }

            if(Membership.GetUser("ldelaespriella") == null)
            {
                Membership.CreateUser("ldelaespriella", "ldelaespriella");
                Roles.AddUserToRole("ldelaespriella", "Admin");
            }
        }
    }
}
