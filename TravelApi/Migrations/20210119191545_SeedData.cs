using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelApi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationId", "Cons", "Name", "Pros", "Rating" },
                values: new object[,]
                {
                    { 1, "Very Expensive", "New Zealand", "Great for outdoor lovers!", "5 Stars" },
                    { 2, "Rudeness", "France", "Bread", "4 Stars" },
                    { 3, "Might Get Kidnapped", "Somalia", "Very Cheap", "1 Star" },
                    { 4, "Endless Winter", "Antartica", "Snow Angels", "2 Stars" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 4);
        }
    }
}
