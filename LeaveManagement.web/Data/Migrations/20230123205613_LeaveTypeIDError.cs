using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.web.Data.Migrations
{
    public partial class LeaveTypeIDError : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6fa7f81-9cc7-41b6-9661-fba613c2d087",
                column: "ConcurrencyStamp",
                value: "194d60d5-90bb-4e0a-8b49-1e74d3b44a2b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6fb8f81-9dd7-48b8-9771-aea613c2d022",
                column: "ConcurrencyStamp",
                value: "4f8de77b-6f2a-4c6d-bf0f-850af69eccdf");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0972a611-49fa-4f65-a9e4-fddbb724c38a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ccb8f60-2349-4c56-93af-df56ffcb849e", "AQAAAAEAACcQAAAAEObawGOsFa/5I2B2p9wTPW4m/PM+N1qLvUjLCgDiKAIbq+pAZybOgd41+5zSseT6bw==", "37856768-c4aa-41bc-9f7a-17da71708f6c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6fa7f91-9cc6-41b5-9668-fba613c2d087",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6959a4cf-0d41-4ea9-8635-275328605d50", "AQAAAAEAACcQAAAAEDk62QruaNydNtrDQTDHEgbOvnU9CeN8t68u0s7sAhMwPH0a2JFqeGLRqkfDsbE8PA==", "6e44fafa-c251-401d-a8af-2b3040e0ce55" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
