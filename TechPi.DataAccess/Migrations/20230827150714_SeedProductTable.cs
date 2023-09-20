using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TechPi.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedProductTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L);
        }
    }
}
