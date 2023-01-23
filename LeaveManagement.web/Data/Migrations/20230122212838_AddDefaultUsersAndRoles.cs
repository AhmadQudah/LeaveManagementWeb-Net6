using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.web.Data.Migrations
{
    public partial class AddDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d6fa7f81-9cc7-41b6-9661-fba613c2d087", "82dcdc63-6056-4893-9a2f-f43f7566d04c", "Administrator", "ADMINISTRATOR" },
                    { "d6fb8f81-9dd7-48b8-9771-aea613c2d022", "d47f7fdc-65ee-4624-8c2c-f35be1471e8b", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "DateOfJoin", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TextId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0972a611-49fa-4f65-a9e4-fddbb724c38a", 0, "8d3f2df6-f873-4688-82cf-6a25ba0dba28", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ahmad@test.com", false, "Ahmad", "Test", false, null, "AHMAD@TEST.COM", null, "AQAAAAEAACcQAAAAENsZpJr1F4WkmKHo9whfiyop7HCda33mMbJUhNl+YbYzPrHpkIFzRlnAbtyIkJboag==", null, false, "c45d8c81-c26a-455c-bd55-728af2434512", null, false, null },
                    { "d6fa7f91-9cc6-41b5-9668-fba613c2d087", 0, "410402e2-58b3-4de9-afbd-594939fa3d0f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ahiq95@gmail.com", false, "Ahmad", "Qudah", false, null, "AHIQ95@GMAIL.COM", null, "AQAAAAEAACcQAAAAENCx1HR2fJGQ3ZYjMQUIJl+w9LZPNHlUA6C8ZzYwK8rDp+IUFKlkKehCZ8b8W8wPWA==", null, false, "b90ab141-db75-44e5-8690-b3a4695e3c8c", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d6fb8f81-9dd7-48b8-9771-aea613c2d022", "0972a611-49fa-4f65-a9e4-fddbb724c38a" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d6fa7f81-9cc7-41b6-9661-fba613c2d087", "d6fa7f91-9cc6-41b5-9668-fba613c2d087" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d6fb8f81-9dd7-48b8-9771-aea613c2d022", "0972a611-49fa-4f65-a9e4-fddbb724c38a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d6fa7f81-9cc7-41b6-9661-fba613c2d087", "d6fa7f91-9cc6-41b5-9668-fba613c2d087" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6fa7f81-9cc7-41b6-9661-fba613c2d087");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6fb8f81-9dd7-48b8-9771-aea613c2d022");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0972a611-49fa-4f65-a9e4-fddbb724c38a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6fa7f91-9cc6-41b5-9668-fba613c2d087");
        }
    }
}
