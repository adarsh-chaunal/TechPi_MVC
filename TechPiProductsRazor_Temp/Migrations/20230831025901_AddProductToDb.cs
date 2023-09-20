using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TechPiProductsRazor_Temp.Migrations
{
    /// <inheritdoc />
    public partial class AddProductToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ProductCode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    ProductDescription = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InStock = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Created", "DisplayOrder", "InStock", "Price", "ProductCode", "ProductDescription", "ProductName" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 8, 27, 8, 30, 39, 999, DateTimeKind.Unspecified), 1, true, 100.00m, "12345", "First Product", "Product1" },
                    { 2L, new DateTime(2023, 8, 28, 10, 41, 3, 101, DateTimeKind.Unspecified), 2, false, 200.00m, "12346", "Second Product", "Product2" }
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
