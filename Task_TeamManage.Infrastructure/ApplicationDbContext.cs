using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_TeamManage.Domain.Entities;
using Task_TeamManage.Infrastructure.Identity;
using Task_TeamManage.Infrastructure.Seeds;

namespace Task_TeamManage.Infrastructure
{
    public class ApplicationDbContext:IdentityDbContext<ApplicationUser,ApplicationRole, 
        Guid, ApplicationUserClaim, ApplicationUserRole,
        ApplicationUserLogin, ApplicationRoleClaim, ApplicationUserToken>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }


        public DbSet<TaskItem> TaskItems { get; set; }
        public DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ApplicationRole>().HasData(RoleSeed.GetRoles());
            builder.Entity<ApplicationUser>().HasData(UserSeed.GetUsers());
            builder.Entity<ApplicationUserRole>().HasData(UserRoleSeed.GetUserRoles());
            base.OnModelCreating(builder);
        }
    }
    
}
