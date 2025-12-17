using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_TeamManage.Infrastructure.Identity;

namespace Task_TeamManage.Infrastructure.Seeds
{
    public static class RoleSeed
    {
        public static ApplicationRole[] GetRoles()
        {
            return new ApplicationRole[]
            {
                new ApplicationRole{
                    Id = new Guid("f6208531-bd28-43b0-a108-e4c1f5c78b6f"),
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                    ConcurrencyStamp = new DateTime(2025, 9, 15, 16, 10, 30).ToString()
                },
                new ApplicationRole{
                    Id = new Guid("9c26e64a-35b8-43ff-b0a6-586a5f4e85a4"),
                    Name = "Manager",
                    NormalizedName = "MANAGER",
                    ConcurrencyStamp = new DateTime(2023, 9, 10, 8, 5, 12).ToString()
                },
                new ApplicationRole{
                    Id = new Guid("5dd80867-62ba-4368-8d68-386e403974e6"),
                    Name = "Employee",
                    NormalizedName = "EMPLOYEE",
                    ConcurrencyStamp = new DateTime(2021, 8, 11, 1, 2, 1).ToString()
                },

            };
                
             
        }
    }
}
