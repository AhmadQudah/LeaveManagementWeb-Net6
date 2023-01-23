using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.web.Data.Migrations
{
    public partial class AddedDefaultUsersAndUserNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6fa7f81-9cc7-41b6-9661-fba613c2d087",
                column: "ConcurrencyStamp",
                value: "943bd93a-1930-4cce-ba91-0544d0a0eb5a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6fb8f81-9dd7-48b8-9771-aea613c2d022",
                column: "ConcurrencyStamp",
                value: "759dcb3f-fb57-4e46-ac37-851301c6b57b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0972a611-49fa-4f65-a9e4-fddbb724c38a",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "cdd6a446-7eff-4782-b1ce-e91330c71b81", true, "AHMAD@TEST.COM", "AQAAAAEAACcQAAAAEF8hsvrz81hMHNJl3tCpP+fg+2wsWiSJSEzba2vw8rdZhbKUE8MiJjbZbvm4wsks5Q==", "7e213026-9aa2-4ce2-bd83-a223db6c3e8b", "ahmad@test.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6fa7f91-9cc6-41b5-9668-fba613c2d087",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d1fb3250-a033-4dad-ac44-d4c1b32202f6", true, "AHIQ95@GMAIL.COM", "AQAAAAEAACcQAAAAEH2AQP/hb6HleO4+lXnMoKhZ3ZkbrsrMh1yNdJXGzN9kcKfrOhDpSsuhZLvjZyw6gQ==", "e1adcd68-22f6-439a-b60d-f1390cfc4e4e", "ahiq95@gmail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6fa7f81-9cc7-41b6-9661-fba613c2d087",
                column: "ConcurrencyStamp",
                value: "82dcdc63-6056-4893-9a2f-f43f7566d04c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6fb8f81-9dd7-48b8-9771-aea613c2d022",
                column: "ConcurrencyStamp",
                value: "d47f7fdc-65ee-4624-8c2c-f35be1471e8b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0972a611-49fa-4f65-a9e4-fddbb724c38a",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "8d3f2df6-f873-4688-82cf-6a25ba0dba28", false, null, "AQAAAAEAACcQAAAAENsZpJr1F4WkmKHo9whfiyop7HCda33mMbJUhNl+YbYzPrHpkIFzRlnAbtyIkJboag==", "c45d8c81-c26a-455c-bd55-728af2434512", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6fa7f91-9cc6-41b5-9668-fba613c2d087",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "410402e2-58b3-4de9-afbd-594939fa3d0f", false, null, "AQAAAAEAACcQAAAAENCx1HR2fJGQ3ZYjMQUIJl+w9LZPNHlUA6C8ZzYwK8rDp+IUFKlkKehCZ8b8W8wPWA==", "b90ab141-db75-44e5-8690-b3a4695e3c8c", null });
        }
    }
}
