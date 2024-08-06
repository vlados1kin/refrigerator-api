using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Refrigerator.API.Migrations
{
    /// <inheritdoc />
    public partial class Edit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "DefaultQuantity", "Name" },
                values: new object[,]
                {
                    { new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), 3, "Watermelon" },
                    { new Guid("1d490a70-94ce-4d15-9494-5248280c2ce3"), 5, "Apple" },
                    { new Guid("a9d4c053-49b6-410c-bc78-2d54a9991870"), 10, "Cucumber" }
                });

            migrationBuilder.InsertData(
                table: "FridgeProducts",
                columns: new[] { "FridgeProductId", "FridgeId", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { new Guid("b9d4c053-49b5-410c-bc78-2d54a9991870"), new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), 0 },
                    { new Guid("c9d4c053-49b1-410c-bc78-2d54a9991870"), new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), new Guid("1d490a70-94ce-4d15-9494-5248280c2ce3"), 0 },
                    { new Guid("c9d4c053-49b5-410c-bc78-2d54a9991870"), new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), new Guid("a9d4c053-49b6-410c-bc78-2d54a9991870"), 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FridgeProducts",
                keyColumn: "FridgeProductId",
                keyValue: new Guid("b9d4c053-49b5-410c-bc78-2d54a9991870"));

            migrationBuilder.DeleteData(
                table: "FridgeProducts",
                keyColumn: "FridgeProductId",
                keyValue: new Guid("c9d4c053-49b1-410c-bc78-2d54a9991870"));

            migrationBuilder.DeleteData(
                table: "FridgeProducts",
                keyColumn: "FridgeProductId",
                keyValue: new Guid("c9d4c053-49b5-410c-bc78-2d54a9991870"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1d490a70-94ce-4d15-9494-5248280c2ce3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a9d4c053-49b6-410c-bc78-2d54a9991870"));
        }
    }
}
