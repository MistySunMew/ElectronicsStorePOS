using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElectronicsStorePOS.Migrations
{
    /// <inheritdoc />
    public partial class ProductRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductRelations",
                columns: table => new
                {
                    Product1ID = table.Column<int>(type: "int", nullable: false),
                    Product2ID = table.Column<int>(type: "int", nullable: false),
                    RelationRating = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductRelations", x => new { x.Product1ID, x.Product2ID });
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductRelations");
        }
    }
}
