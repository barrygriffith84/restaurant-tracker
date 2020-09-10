using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurantTracker.Data.Migrations
{
    public partial class tableseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Table",
                columns: new[] { "Id", "Name", "WaiterId" },
                values: new object[] { 1, "Table 1", 1 });

            migrationBuilder.InsertData(
                table: "Table",
                columns: new[] { "Id", "Name", "WaiterId" },
                values: new object[] { 2, "Table 2", 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
