using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.web.Data.Migrations
{
    public partial class AddingPriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6fa7f81-9cc7-41b6-9661-fba613c2d087",
                column: "ConcurrencyStamp",
                value: "78c9b7a4-c3f3-4eeb-8cd5-28c777ccf0de");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6fb8f81-9dd7-48b8-9771-aea613c2d022",
                column: "ConcurrencyStamp",
                value: "d51b68ce-3838-4704-a86c-43989038c366");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0972a611-49fa-4f65-a9e4-fddbb724c38a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1616806e-3aad-4fa4-8a5b-4ba93245e31f", "AQAAAAEAACcQAAAAEHkx92XvKAvZheEZ9whdRVF1T2h1HkDWElz+rT3XgA5qvYCAWPzh+A8EDfJpx6+j7Q==", "127d35bd-981e-4618-a63f-86ff48de0257" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6fa7f91-9cc6-41b5-9668-fba613c2d087",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "27c3e179-0a6d-4c08-bea1-5ab2fdb1a985", "AQAAAAEAACcQAAAAENK6QL9pGwBo48qhvzi+KcXeMyH28ZLoD+vX0POfm0tVhuWWQh840byO/rZMcY8vRQ==", "9c56e7ee-d530-4ad0-8c18-dd840d9cede1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cdd6a446-7eff-4782-b1ce-e91330c71b81", "AQAAAAEAACcQAAAAEF8hsvrz81hMHNJl3tCpP+fg+2wsWiSJSEzba2vw8rdZhbKUE8MiJjbZbvm4wsks5Q==", "7e213026-9aa2-4ce2-bd83-a223db6c3e8b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6fa7f91-9cc6-41b5-9668-fba613c2d087",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1fb3250-a033-4dad-ac44-d4c1b32202f6", "AQAAAAEAACcQAAAAEH2AQP/hb6HleO4+lXnMoKhZ3ZkbrsrMh1yNdJXGzN9kcKfrOhDpSsuhZLvjZyw6gQ==", "e1adcd68-22f6-439a-b60d-f1390cfc4e4e" });
        }
    }
}
