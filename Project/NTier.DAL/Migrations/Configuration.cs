namespace NTier.DAL.Migrations
{
    using Model.Model.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Security.Principal;
    using Utility;

    internal sealed class Configuration : DbMigrationsConfiguration<NTier.DAL.DAL.Context.ProjectContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(NTier.DAL.DAL.Context.ProjectContext context)
        {
            AppUser user = new AppUser() {
                Name = "Hakan",
                LastName = "Pasinli",
                UserName = "admin",
                Password = "123",
                Role = Role.Admin,
                Status = Core.Core.ENum.Entity.Status.Active,
                Address = "2475 Langtown Road,Wapakoneta,OH,Ohio",
                Email = "hakanpasinli@hotmail.com",
                PhoneNumber = "567-356-2846",
                CreatedADUserName = WindowsIdentity.GetCurrent().Name,
                CreatedDate = DateTime.UtcNow,
                CreatedComputerName = Environment.MachineName,
                CreatedIp=RemoteIP.IpAddress
            };

            context.Users.AddOrUpdate(user);
            base.Seed(context);
        }
    }
}
