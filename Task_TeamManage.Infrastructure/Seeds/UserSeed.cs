using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_TeamManage.Infrastructure.Identity;

namespace Task_TeamManage.Infrastructure.Seeds
{
    public static class UserSeed
    {
        public static ApplicationUser[] GetUsers()
        {
            var admin = new ApplicationUser
            {
                Id = new Guid("d38825ce-b162-49a6-b8b9-7687579953d4"),
                UserName = "admin@demo.com",
                NormalizedUserName = "ADMIN@DEMO.COM",
                Email = "admin@demo.com",
                NormalizedEmail= "ADMIN@DEMO.COM",
                EmailConfirmed = true,
                FullName = "Admin",
                ConcurrencyStamp = "223ab15b-edee-4dc0-9d0f-3178f87d23e4",
                SecurityStamp = "6ff0bd1c-745b-4fd9-af7e-274c2eb2519a",
                PasswordHash = "AQAAAAIAAYagAAAAEOmrA80QZu2djiUDc90YZ+Rh3id9e+o2hU13dCcbHfLvgmm+FUjzSD8yVH7XM0Eaig=="

            };
            

            var manager = new ApplicationUser
            {
                Id = new Guid("fc410552-d197-4131-b54b-4d6722e18523"),
                UserName = "manager@demo.com",
                NormalizedUserName = "MANAGER@DEMO.COM",
                Email = "manager@demo.com",
                NormalizedEmail = "MANAGER@DEMO.COM",
                EmailConfirmed = true,
                FullName = "Manager",
                ConcurrencyStamp = "68136f2d-242c-4cbf-a1ba-c4fdac32984b",
                SecurityStamp = "be26a5af-f4a6-440e-88e8-665307aaf22d",
                PasswordHash = "AQAAAAIAAYagAAAAEMQBdFM2i1SoOh9ZNIxdlDuhAm7e07KnWHRF16B2hMPigXcqqEUMCOw8VHHEKGErsQ=="

            };
            

            var employee = new ApplicationUser
            {
                Id = new Guid("5f3bbadc-0a4c-4886-98dd-2f87ac8fa71d"),
                UserName = "employee@demo.com",
                NormalizedUserName = "EMPLOYEE@DEMO.COM",
                Email = "employee@demo.com",
                NormalizedEmail = "EMPLOYEE@DEMO.COM",
                EmailConfirmed = true,
                FullName = "Employee",
                ConcurrencyStamp = "64389e61-37cc-48b3-8b36-cf0bda179dcc",
                SecurityStamp = "5acef609-9f26-4c8c-87ba-b2738c93f606",
                PasswordHash = "AQAAAAIAAYagAAAAENdXwPvEQ8m8zxMtgoGUTi1PopIH2/RZc3bh79T3kGQg8ARHQ3Y50SMUqA17JKeD1Q=="

            };
           
            return new ApplicationUser[] { admin,manager,employee };
        }
    }
}
