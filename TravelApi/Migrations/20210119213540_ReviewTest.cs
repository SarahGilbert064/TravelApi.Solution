using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelApi.Migrations
{
    public partial class ReviewTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cons",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "Pros",
                table: "Locations");

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "Reviews",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Body", "LocationId", "UserName" },
                values: new object[] { 1, "Great hiking and backpacking! Beautiful country!", 1, "Patrick" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Body", "LocationId", "UserName" },
                values: new object[] { 2, "So much history and art! People are kinda rude though.", 2, "Sarah" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Body", "LocationId", "UserName" },
                values: new object[] { 3, "Very very cold but pretty", 4, "Bobby" });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_LocationId",
                table: "Reviews",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Locations_LocationId",
                table: "Reviews",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Locations_LocationId",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_LocationId",
                table: "Reviews");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Reviews");

            migrationBuilder.AddColumn<string>(
                name: "Cons",
                table: "Locations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pros",
                table: "Locations",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 1,
                columns: new[] { "Cons", "Pros" },
                values: new object[] { "Very Expensive", "Great for outdoor lovers!" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 2,
                columns: new[] { "Cons", "Pros" },
                values: new object[] { "Rudeness", "Bread" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 3,
                columns: new[] { "Cons", "Pros" },
                values: new object[] { "Might Get Kidnapped", "Very Cheap" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 4,
                columns: new[] { "Cons", "Pros" },
                values: new object[] { "Endless Winter", "Snow Angels" });
        }
    }
}
