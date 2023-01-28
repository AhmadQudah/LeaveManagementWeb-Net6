using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.web.Data.Migrations
{
    public partial class UpdatedRequestComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComment",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6fa7f81-9cc7-41b6-9661-fba613c2d087",
                column: "ConcurrencyStamp",
                value: "4c76b9f5-ac29-412e-b5a8-4851a694ea50");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6fb8f81-9dd7-48b8-9771-aea613c2d022",
                column: "ConcurrencyStamp",
                value: "ff26461e-e6e4-45cd-93d0-11941d521bf7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0972a611-49fa-4f65-a9e4-fddbb724c38a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "338a0364-6bf6-4b78-af98-b1ff42d00d23", "AQAAAAEAACcQAAAAEA7Agvz+lCOF3+Bz7oxANRzDlGXXuc+UtQrGboEvLDZZ5O3Sfxpk3jOfBZuZ/Xy6uw==", "b4c8bcf1-a640-44ae-904e-f65d1f59edc1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6fa7f91-9cc6-41b5-9668-fba613c2d087",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f1541dc-6bf2-4885-a0f0-ea275563bddd", "AQAAAAEAACcQAAAAELemByFDVjcn1wdZJhW2CXfqhlO60dq0LX+GoSZFn6bz5ai7iC9VdYPr7ulARyZrkw==", "18183c5f-9378-4009-a270-57fdd5773673" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComment",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6fa7f81-9cc7-41b6-9661-fba613c2d087",
                column: "ConcurrencyStamp",
                value: "dde33bb3-6e80-46be-8b8e-e299a9d99d92");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6fb8f81-9dd7-48b8-9771-aea613c2d022",
                column: "ConcurrencyStamp",
                value: "ff143363-aac2-4152-84cd-c527d6b83f8f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0972a611-49fa-4f65-a9e4-fddbb724c38a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d3a1e19-d183-48e4-928b-1369d9f478b8", "AQAAAAEAACcQAAAAEGGN8WRsFHyNE4HWJxlpab4X5fwRaR1+lJa9KUQKyoNfUtFXf0e2Yi62Mw5QBETf0g==", "ba255911-4897-44e5-920a-03c3d1b8e14c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6fa7f91-9cc6-41b5-9668-fba613c2d087",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "198f9c19-950e-45db-8435-03968af39427", "AQAAAAEAACcQAAAAEP0uEaDSjJz45TGhOYgc85ETN8wRAgg11kDhIJr1m/BDVr/uyvB+NEqDAuMKeteFqg==", "3b29dcdd-4250-4cd5-bcca-d29be17e92ea" });
        }
    }
}
