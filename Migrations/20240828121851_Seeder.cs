using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace hw_ShopDb.Migrations
{
    /// <inheritdoc />
    public partial class Seeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "Electronics" },
                    { 2, "Books" }
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "CountryId", "Name" },
                values: new object[,]
                {
                    { 1, "USA" },
                    { 2, "Canada" }
                });

            migrationBuilder.InsertData(
                table: "Position",
                columns: new[] { "PositionId", "Name" },
                values: new object[,]
                {
                    { 1, "Manager" },
                    { 2, "Cashier" }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "CityId", "CountryId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "New York" },
                    { 2, 1, "Los Angeles" },
                    { 3, 2, "Toronto" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "CategoryId", "Discount", "IsInStock", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 0f, false, "Laptop", 999.99m, 0 },
                    { 2, 1, 0f, false, "Smartphone", 499.99m, 0 },
                    { 3, 2, 0f, false, "Fiction Book", 19.99m, 0 }
                });

            migrationBuilder.InsertData(
                table: "Shop",
                columns: new[] { "ShopId", "Address", "CityId", "Name", "ParkingArea" },
                values: new object[,]
                {
                    { 1, "123 Tech Road", 1, "TechStore", null },
                    { 2, "456 Book Street", 2, "BookStore", null }
                });

            migrationBuilder.InsertData(
                table: "Worker",
                columns: new[] { "WorkerId", "Email", "Name", "PhoneNumber", "PoditionId", "Salary", "ShopId", "Surname" },
                values: new object[,]
                {
                    { 1, "john.doe@example.com", "John", "555-1234", 1, 60000m, 1, "Doe" },
                    { 2, "jane.smith@example.com", "Jane", "555-5678", 2, 45000m, 2, "Smith" },
                    { 3, "mike.johnson@example.com", "Mike", "555-8765", 2, 40000m, 1, "Johnson" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Worker",
                keyColumn: "WorkerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Worker",
                keyColumn: "WorkerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Worker",
                keyColumn: "WorkerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Position",
                keyColumn: "PositionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Position",
                keyColumn: "PositionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Shop",
                keyColumn: "ShopId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Shop",
                keyColumn: "ShopId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 1);
        }
    }
}
