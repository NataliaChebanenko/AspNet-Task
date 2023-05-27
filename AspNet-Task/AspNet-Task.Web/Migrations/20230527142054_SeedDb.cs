using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspNet_Task.Web.Migrations
{
    public partial class SeedDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "New" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Popular" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Featured" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Color", "Description", "ImageUrl", "Name", "Price", "SKU" },
                values: new object[,]
                {
                    { 1, 1, "Yellow", "The phone that tells you jokes", "https://example.com/sillyphone.jpg", "Silly Smartphone", 99.99m, "SKUSM001" },
                    { 2, 2, "Purple", "A stylish hat for the trendsetters", "https://example.com/funkyfedora.jpg", "Funky Fedora", 49.99m, "SKUFF001" },
                    { 3, 3, "Green", "A clock that dances on your wall", "https://example.com/whimsicalclock.jpg", "Whimsical Wall Clock", 29.99m, "SKUWC001" },
                    { 4, 1, "Multi-color", "Stretch it, squish it, have endless fun", "https://example.com/goofygoo.jpg", "Goofy Goo", 9.99m, "SKUGG001" },
                    { 5, 2, "Black/White", "Skate in style with zebra stripes", "https://example.com/zebraskates.jpg", "Zany Zebra Roller Skates", 79.99m, "SKUZS001" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
