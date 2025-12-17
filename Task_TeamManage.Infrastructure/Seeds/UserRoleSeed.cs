using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_TeamManage.Infrastructure.Identity;

namespace Task_TeamManage.Infrastructure.Seeds
{
    public static class UserRoleSeed
    {
        public static ApplicationUserRole[] GetUserRoles()
        {
            return new[]
            {
                //Admin User
                new ApplicationUserRole
                {
                    UserId = new Guid("d38825ce-b162-49a6-b8b9-7687579953d4"),
                    RoleId = new Guid("f6208531-bd28-43b0-a108-e4c1f5c78b6f")
                },
                // Manager User
                new ApplicationUserRole
                {
                    UserId = new Guid("fc410552-d197-4131-b54b-4d6722e18523"),
                    RoleId = new Guid("9c26e64a-35b8-43ff-b0a6-586a5f4e85a4")
                },
                //Employee User
                new ApplicationUserRole
                {
                    UserId = new Guid("5f3bbadc-0a4c-4886-98dd-2f87ac8fa71d"),
                    RoleId = new Guid("5dd80867-62ba-4368-8d68-386e403974e6")
                }
            };
        }
    }
}
