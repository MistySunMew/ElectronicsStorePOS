using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ElectronicsStorePOS.Migrations
{
    /// <inheritdoc />
    public partial class ProductRelationData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProductRelations",
                columns: new[] { "Product1ID", "Product2ID", "RelationRating" },
                values: new object[,]
                {
                    { 1, 1, (byte)5 },
                    { 1, 2, (byte)4 },
                    { 1, 3, (byte)5 },
                    { 1, 4, (byte)5 },
                    { 1, 6, (byte)5 },
                    { 1, 7, (byte)3 },
                    { 1, 9, (byte)3 },
                    { 1, 10, (byte)5 },
                    { 1, 12, (byte)4 },
                    { 1, 35, (byte)4 },
                    { 1, 37, (byte)3 },
                    { 2, 1, (byte)5 },
                    { 2, 2, (byte)5 },
                    { 2, 3, (byte)5 },
                    { 2, 5, (byte)4 },
                    { 2, 6, (byte)5 },
                    { 2, 7, (byte)4 },
                    { 2, 11, (byte)5 },
                    { 2, 15, (byte)3 },
                    { 2, 35, (byte)5 },
                    { 2, 37, (byte)4 },
                    { 3, 7, (byte)4 },
                    { 5, 10, (byte)4 },
                    { 6, 10, (byte)3 },
                    { 19, 20, (byte)5 },
                    { 19, 22, (byte)5 },
                    { 21, 18, (byte)5 },
                    { 21, 22, (byte)5 },
                    { 23, 18, (byte)5 },
                    { 23, 20, (byte)5 },
                    { 28, 41, (byte)5 },
                    { 29, 37, (byte)5 },
                    { 29, 40, (byte)5 },
                    { 32, 33, (byte)3 },
                    { 34, 31, (byte)5 },
                    { 37, 17, (byte)5 },
                    { 37, 18, (byte)4 },
                    { 37, 19, (byte)4 },
                    { 37, 33, (byte)4 },
                    { 38, 16, (byte)4 },
                    { 38, 20, (byte)5 },
                    { 38, 21, (byte)5 },
                    { 40, 43, (byte)5 },
                    { 42, 42, (byte)5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductRelations",
                keyColumns: new[] { "Product1ID", "Product2ID" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ProductRelations",
                keyColumns: new[] { "Product1ID", "Product2ID" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "ProductRelations",
                keyColumns: new[] { "Product1ID", "Product2ID" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "ProductRelations",
                keyColumns: new[] { "Product1ID", "Product2ID" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "ProductRelations",
                keyColumns: new[] { "Product1ID", "Product2ID" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "ProductRelations",
                keyColumns: new[] { "Product1ID", "Product2ID" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "ProductRelations",
                keyColumns: new[] { "Product1ID", "Product2ID" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "ProductRelations",
                keyColumns: new[] { "Product1ID", "Product2ID" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "ProductRelations",
                keyColumns: new[] { "Product1ID", "Product2ID" },
                keyValues: new object[] { 1, 12 });

            migrationBuilder.DeleteData(
                table: "ProductRelations",
                keyColumns: new[] { "Product1ID", "Product2ID" },
                keyValues: new object[] { 1, 35 });

            migrationBuilder.DeleteData(
                table: "ProductRelations",
                keyColumns: new[] { "Product1ID", "Product2ID" },
                keyValues: new object[] { 1, 37 });

            migrationBuilder.DeleteData(
                table: "ProductRelations",
                keyColumns: new[] { "Product1ID", "Product2ID" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "ProductRelations",
                keyColumns: new[] { "Product1ID", "Product2ID" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "ProductRelations",
                keyColumns: new[] { "Product1ID", "Product2ID" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "ProductRelations",
                keyColumns: new[] { "Product1ID", "Product2ID" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "ProductRelations",
                keyColumns: new[] { "Product1ID", "Product2ID" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "ProductRelations",
                keyColumns: new[] { "Product1ID", "Product2ID" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "ProductRelations",
                keyColumns: new[] { "Product1ID", "Product2ID" },
                keyValues: new object[] { 2, 11 });

            migrationBuilder.DeleteData(
                table: "ProductRelations",
                keyColumns: new[] { "Product1ID", "Product2ID" },
                keyValues: new object[] { 2, 15 });

            migrationBuilder.DeleteData(
                table: "ProductRelations",
                keyColumns: new[] { "Product1ID", "Product2ID" },
                keyValues: new object[] { 2, 35 });

            migrationBuilder.DeleteData(
                table: "ProductRelations",
                keyColumns: new[] { "Product1ID", "Product2ID" },
                keyValues: new object[] { 2, 37 });

            migrationBuilder.DeleteData(
                table: "ProductRelations",
                keyColumns: new[] { "Product1ID", "Product2ID" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "ProductRelations",
                keyColumns: new[] { "Product1ID", "Product2ID" },
                keyValues: new object[] { 5, 10 });

            migrationBuilder.DeleteData(
                table: "ProductRelations",
                keyColumns: new[] { "Product1ID", "Product2ID" },
                keyValues: new object[] { 6, 10 });

            migrationBuilder.DeleteData(
                table: "ProductRelations",
                keyColumns: new[] { "Product1ID", "Product2ID" },
                keyValues: new object[] { 19, 20 });

            migrationBuilder.DeleteData(
                table: "ProductRelations",
                keyColumns: new[] { "Product1ID", "Product2ID" },
                keyValues: new object[] { 19, 22 });

            migrationBuilder.DeleteData(
                table: "ProductRelations",
                keyColumns: new[] { "Product1ID", "Product2ID" },
                keyValues: new object[] { 21, 18 });

            migrationBuilder.DeleteData(
                table: "ProductRelations",
                keyColumns: new[] { "Product1ID", "Product2ID" },
                keyValues: new object[] { 21, 22 });

            migrationBuilder.DeleteData(
                table: "ProductRelations",
                keyColumns: new[] { "Product1ID", "Product2ID" },
                keyValues: new object[] { 23, 18 });

            migrationBuilder.DeleteData(
                table: "ProductRelations",
                keyColumns: new[] { "Product1ID", "Product2ID" },
                keyValues: new object[] { 23, 20 });

            migrationBuilder.DeleteData(
                table: "ProductRelations",
                keyColumns: new[] { "Product1ID", "Product2ID" },
                keyValues: new object[] { 28, 41 });

            migrationBuilder.DeleteData(
                table: "ProductRelations",
                keyColumns: new[] { "Product1ID", "Product2ID" },
                keyValues: new object[] { 29, 37 });

            migrationBuilder.DeleteData(
                table: "ProductRelations",
                keyColumns: new[] { "Product1ID", "Product2ID" },
                keyValues: new object[] { 29, 40 });

            migrationBuilder.DeleteData(
                table: "ProductRelations",
                keyColumns: new[] { "Product1ID", "Product2ID" },
                keyValues: new object[] { 32, 33 });

            migrationBuilder.DeleteData(
                table: "ProductRelations",
                keyColumns: new[] { "Product1ID", "Product2ID" },
                keyValues: new object[] { 34, 31 });

            migrationBuilder.DeleteData(
                table: "ProductRelations",
                keyColumns: new[] { "Product1ID", "Product2ID" },
                keyValues: new object[] { 37, 17 });

            migrationBuilder.DeleteData(
                table: "ProductRelations",
                keyColumns: new[] { "Product1ID", "Product2ID" },
                keyValues: new object[] { 37, 18 });

            migrationBuilder.DeleteData(
                table: "ProductRelations",
                keyColumns: new[] { "Product1ID", "Product2ID" },
                keyValues: new object[] { 37, 19 });

            migrationBuilder.DeleteData(
                table: "ProductRelations",
                keyColumns: new[] { "Product1ID", "Product2ID" },
                keyValues: new object[] { 37, 33 });

            migrationBuilder.DeleteData(
                table: "ProductRelations",
                keyColumns: new[] { "Product1ID", "Product2ID" },
                keyValues: new object[] { 38, 16 });

            migrationBuilder.DeleteData(
                table: "ProductRelations",
                keyColumns: new[] { "Product1ID", "Product2ID" },
                keyValues: new object[] { 38, 20 });

            migrationBuilder.DeleteData(
                table: "ProductRelations",
                keyColumns: new[] { "Product1ID", "Product2ID" },
                keyValues: new object[] { 38, 21 });

            migrationBuilder.DeleteData(
                table: "ProductRelations",
                keyColumns: new[] { "Product1ID", "Product2ID" },
                keyValues: new object[] { 40, 43 });

            migrationBuilder.DeleteData(
                table: "ProductRelations",
                keyColumns: new[] { "Product1ID", "Product2ID" },
                keyValues: new object[] { 42, 42 });
        }
    }
}
