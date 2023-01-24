using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.web.Data.Migrations
{
    public partial class CahngeForeignKeyFromLeaveTypeTypeIdToLeaveTypeId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LeaveTypeTypeId",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6fa7f81-9cc7-41b6-9661-fba613c2d087",
                column: "ConcurrencyStamp",
                value: "c2e54e44-a496-4b7e-8351-5c2ae5d76bad");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6fb8f81-9dd7-48b8-9771-aea613c2d022",
                column: "ConcurrencyStamp",
                value: "3efc8fdd-ce28-479f-88f0-0c11e84a0c0e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0972a611-49fa-4f65-a9e4-fddbb724c38a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5843618d-c5bd-49f0-8189-2e5b906d0cc7", "AQAAAAEAACcQAAAAEKonYT+bDeB1c3rXFbkWpJnpplsPnTHWM59FHvosPTC+BhuSb64jyYMNEoWnOHT4xw==", "188b8396-937d-4b87-8a61-20f4eb2b3cbf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6fa7f91-9cc6-41b5-9668-fba613c2d087",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66325813-84d3-442c-a82d-32f414780ebf", "AQAAAAEAACcQAAAAEL8C4ErxGrKB06leXEr+ZwpgtI1g7kU/GF0odXLPEUdn0Bs5wUJS3q0LtqOClYHkvQ==", "b8e9d6f6-7258-42c5-b6e5-f727bd0afad4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LeaveTypeTypeId",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}
