using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ElectronicsStorePOS.Migrations
{
    /// <inheritdoc />
    public partial class InitialCommit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SKU = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "Category", "Desc", "Name", "Price", "Rating", "SKU" },
                values: new object[,]
                {
                    { 1, "Console", null, "PlayStation 5", 499.99000000000001, null, "6426149" },
                    { 2, "Console", null, "PlayStation 5 Digital Edition", 399.99000000000001, null, "6430161" },
                    { 3, "Game", null, "Horizon Forbidden West", 69.989999999999995, "T", "6479466" },
                    { 4, "Game", null, "Demon Souls", 69.989999999999995, "M", "6430152" },
                    { 5, "Game", null, "Sackboy: A Big Adventure", 59.990000000000002, "E", "6430149" },
                    { 6, "Game", null, "Marvel's Spider-Man: Miles Morales", 49.990000000000002, "T", "6430146" },
                    { 7, "Game", null, "Gran Turismo 7", 69.989999999999995, "T", "6501071" },
                    { 8, "Game", null, "The Nioh Collection", 69.989999999999995, "M", "6442989" },
                    { 9, "Game", null, "Ratchet & Clank: Rift Apart", 69.989999999999995, "E10+", "6463683" },
                    { 10, "Game", null, "UNCHARTED: Legacy of Thieves Collection", 49.990000000000002, "T", "6491840" },
                    { 11, "Game", null, "The Last of Us Part 1", 69.989999999999995, "M", "6510195" },
                    { 12, "Game", null, "Destruction AllStars", 19.989999999999998, "T", "6459523" },
                    { 13, "Accessory", null, "Astro A30 Headphones", 229.99000000000001, null, "6515569" },
                    { 14, "Accessory", null, "Astro A10 Headphones", 59.990000000000002, null, "6224200" },
                    { 15, "Accessory", null, "Astro A40 Headphones", 129.99000000000001, null, "6278220" },
                    { 16, "Accessory", null, "Blue Yeti Microphone", 129.99000000000001, null, "9737441" },
                    { 17, "Accessory", null, "Blue Snowball Microphone", 69.989999999999995, null, "9918056" },
                    { 18, "Accessory", null, "Razer BlackWidow V3 Keyboard", 139.99000000000001, null, "6425360" },
                    { 19, "Accessory", null, "Razer Naga Trinity Mouse", 69.989999999999995, null, "6172049" },
                    { 20, "Accessory", null, "Logitech G715 Keyboard", 199.99000000000001, null, "6511306" },
                    { 21, "Accessory", null, "Logitech G502 X PLUS LIGHTSPEED Mouse", 159.99000000000001, null, "6512122" },
                    { 22, "Accessory", null, "SteelSeries - Apex 3 Keyboard", 39.990000000000002, null, "6396205" },
                    { 23, "Accessory", null, "SteelSeries - Aerox 3 Mouse", 39.990000000000002, null, "6485248" },
                    { 24, "PC Component", null, "Intel Core i9-13900F", 609.99000000000001, null, "N82E1689118412" },
                    { 25, "PC Component", null, "Intel Core i7-11700KF", 269.99000000000001, null, "9SIBGW5J9X8036" },
                    { 26, "PC Component", null, "AMD Ryzen 9 5950X", 799.0, null, "N82E1689113663" },
                    { 27, "PC Component", null, "AMD Ryzen 5 7600X", 2249.0, null, "N82E1689113770" },
                    { 28, "PC Component", null, "GIGABYTE B550 AM4 Motherboard", 139.99000000000001, null, "N82E16813145433" },
                    { 29, "PC Component", null, "EVGA Z790 LGA1700 Motherboard", 699.99000000000001, null, "N82E16813188206" },
                    { 30, "PC Component", null, "NVIDIA GeForce RTX 4080", 11999.99, null, "6521431" },
                    { 31, "PC Component", null, "AMD Radeon RX 7900 XTX", 999.0, null, "6528715" },
                    { 32, "Storage Device", null, "Seagate IronWolf 16TB Hard Drive", 249.99000000000001, null, "6459355" },
                    { 33, "Storage Device", null, "Samsung 980 PRO 2000GB SSD", 199.99000000000001, null, "6485009" },
                    { 34, "Storage Device", null, "SanDisk 512GB Flash Drive", 47.990000000000002, null, "6422265" },
                    { 35, "Display", null, "Samsung 55\" LED 4K TV", 399.99000000000001, null, "6401735" },
                    { 36, "Display", null, "LG 86\" LED 4K TV", 1499.99, null, "6525091" },
                    { 37, "Display", null, "Samsung 32\" 4K Monitor", 399.99000000000001, null, "6401735" },
                    { 38, "Display", null, "AORUS 43\" 4K Monitor", 749.99000000000001, null, "6483970" },
                    { 39, "Software", null, "TurboTax Deluxe 2022", 55.990000000000002, null, "6518337" },
                    { 40, "Software", null, "Adobe Photoshop Elements 2023", 79.989999999999995, null, "6517623" },
                    { 41, "Software", null, "Office Home", 149.99000000000001, null, "6474446" },
                    { 42, "Software", null, "Windows 11 Home", 139.0, null, "6498482" },
                    { 43, "Software", null, "Adobe Acrobat Standard", 358.99000000000001, null, "6434506" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
