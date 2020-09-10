using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurantTracker.Data.Migrations
{
    public partial class SeedWaiter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Waiter",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 1, "Steve", "Adams" });

            migrationBuilder.InsertData(
                table: "Waiter",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 2, "Tommy", "Spurlock" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Waiter",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Waiter",
                keyColumn: "Id",
                keyValue: 2);
        }

        
    }
}
