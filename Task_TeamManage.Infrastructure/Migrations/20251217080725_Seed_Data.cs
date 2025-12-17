using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Task_TeamManage.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Seed_Data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("5dd80867-62ba-4368-8d68-386e403974e6"), "8/11/2021 1:02:01 AM", "Employee", "EMPLOYEE" },
                    { new Guid("9c26e64a-35b8-43ff-b0a6-586a5f4e85a4"), "9/10/2023 8:05:12 AM", "Manager", "MANAGER" },
                    { new Guid("f6208531-bd28-43b0-a108-e4c1f5c78b6f"), "9/15/2025 4:10:30 PM", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("5f3bbadc-0a4c-4886-98dd-2f87ac8fa71d"), 0, "64389e61-37cc-48b3-8b36-cf0bda179dcc", "employee@demo.com", true, "Employee", false, null, "EMPLOYEE@DEMO.COM", "EMPLOYEE@DEMO.COM", "AQAAAAIAAYagAAAAENdXwPvEQ8m8zxMtgoGUTi1PopIH2/RZc3bh79T3kGQg8ARHQ3Y50SMUqA17JKeD1Q==", null, false, "5acef609-9f26-4c8c-87ba-b2738c93f606", false, "employee@demo.com" },
                    { new Guid("d38825ce-b162-49a6-b8b9-7687579953d4"), 0, "223ab15b-edee-4dc0-9d0f-3178f87d23e4", "admin@demo.com", true, "Admin", false, null, "ADMIN@DEMO.COM", "ADMIN@DEMO.COM", "AQAAAAIAAYagAAAAEOmrA80QZu2djiUDc90YZ+Rh3id9e+o2hU13dCcbHfLvgmm+FUjzSD8yVH7XM0Eaig==", null, false, "6ff0bd1c-745b-4fd9-af7e-274c2eb2519a", false, "admin@demo.com" },
                    { new Guid("fc410552-d197-4131-b54b-4d6722e18523"), 0, "68136f2d-242c-4cbf-a1ba-c4fdac32984b", "manager@demo.com", true, "Manager", false, null, "MANAGER@DEMO.COM", "MANAGER@DEMO.COM", "AQAAAAIAAYagAAAAEMQBdFM2i1SoOh9ZNIxdlDuhAm7e07KnWHRF16B2hMPigXcqqEUMCOw8VHHEKGErsQ==", null, false, "be26a5af-f4a6-440e-88e8-665307aaf22d", false, "manager@demo.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("5dd80867-62ba-4368-8d68-386e403974e6"), new Guid("5f3bbadc-0a4c-4886-98dd-2f87ac8fa71d") },
                    { new Guid("f6208531-bd28-43b0-a108-e4c1f5c78b6f"), new Guid("d38825ce-b162-49a6-b8b9-7687579953d4") },
                    { new Guid("9c26e64a-35b8-43ff-b0a6-586a5f4e85a4"), new Guid("fc410552-d197-4131-b54b-4d6722e18523") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5dd80867-62ba-4368-8d68-386e403974e6"), new Guid("5f3bbadc-0a4c-4886-98dd-2f87ac8fa71d") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("f6208531-bd28-43b0-a108-e4c1f5c78b6f"), new Guid("d38825ce-b162-49a6-b8b9-7687579953d4") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("9c26e64a-35b8-43ff-b0a6-586a5f4e85a4"), new Guid("fc410552-d197-4131-b54b-4d6722e18523") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("5dd80867-62ba-4368-8d68-386e403974e6"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("9c26e64a-35b8-43ff-b0a6-586a5f4e85a4"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f6208531-bd28-43b0-a108-e4c1f5c78b6f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5f3bbadc-0a4c-4886-98dd-2f87ac8fa71d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d38825ce-b162-49a6-b8b9-7687579953d4"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fc410552-d197-4131-b54b-4d6722e18523"));
        }
    }
}
