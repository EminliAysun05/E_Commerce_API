using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerce.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class AddSomeChangesOnUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "RefreshToken",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "RefreshTokenExpiryTime",
                table: "AspNetRoles");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RefreshToken",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RefreshTokenExpiryTime",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2025, 3, 9, 9, 10, 28, 604, DateTimeKind.Utc).AddTicks(3016), "Jewelery & Home" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2025, 3, 9, 9, 10, 28, 604, DateTimeKind.Utc).AddTicks(3071), "Jewelery" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2025, 3, 9, 9, 10, 28, 604, DateTimeKind.Utc).AddTicks(3132), "Beauty, Books & Shoes" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 9, 9, 10, 28, 604, DateTimeKind.Utc).AddTicks(5588));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 9, 9, 10, 28, 604, DateTimeKind.Utc).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 9, 9, 10, 28, 604, DateTimeKind.Utc).AddTicks(5591));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 9, 9, 10, 28, 604, DateTimeKind.Utc).AddTicks(5592));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2025, 3, 9, 9, 10, 28, 605, DateTimeKind.Utc).AddTicks(9257), "Laboriosam est iure quas et.", "Mollitia." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2025, 3, 9, 9, 10, 28, 605, DateTimeKind.Utc).AddTicks(9364), "Culpa ab accusamus iusto tempora.", "Voluptate." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2025, 3, 9, 9, 10, 28, 606, DateTimeKind.Utc).AddTicks(2007), "Omnis nobis quia itaque enim.", "Eum." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2025, 3, 9, 9, 10, 28, 608, DateTimeKind.Utc).AddTicks(3431), "Perspiciatis eveniet molestiae libero aut debitis aut est ut corrupti.", 9.898630551761370m, 45.82m, "Small Granite Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2025, 3, 9, 9, 10, 28, 608, DateTimeKind.Utc).AddTicks(3754), "İpsam ut ad voluptas aut veniam vel et deserunt commodi.", 8.557121384668610m, 990.74m, "Small Metal Car" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RefreshToken",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RefreshTokenExpiryTime",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "AspNetRoles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RefreshToken",
                table: "AspNetRoles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RefreshTokenExpiryTime",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2025, 3, 9, 9, 7, 3, 510, DateTimeKind.Utc).AddTicks(5922), "Home" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2025, 3, 9, 9, 7, 3, 510, DateTimeKind.Utc).AddTicks(6079), "Outdoors, Books & Garden" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2025, 3, 9, 9, 7, 3, 510, DateTimeKind.Utc).AddTicks(6156), "Garden, Garden & Automotive" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 9, 9, 7, 3, 510, DateTimeKind.Utc).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 9, 9, 7, 3, 510, DateTimeKind.Utc).AddTicks(9158));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 9, 9, 7, 3, 510, DateTimeKind.Utc).AddTicks(9160));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 9, 9, 7, 3, 510, DateTimeKind.Utc).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2025, 3, 9, 9, 7, 3, 512, DateTimeKind.Utc).AddTicks(6946), "Blanditiis est quidem debitis tempore.", "Libero." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2025, 3, 9, 9, 7, 3, 512, DateTimeKind.Utc).AddTicks(7079), "Ea et vitae dolor rerum.", "Est." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2025, 3, 9, 9, 7, 3, 512, DateTimeKind.Utc).AddTicks(7183), "Tempore quis temporibus quia necessitatibus.", "Deserunt." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2025, 3, 9, 9, 7, 3, 515, DateTimeKind.Utc).AddTicks(2210), "Ullam quisquam consequatur ut aut sit et dolores similique aut.", 7.66756320431620m, 757.04m, "Small Metal Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2025, 3, 9, 9, 7, 3, 515, DateTimeKind.Utc).AddTicks(2459), "Aut omnis sit sed autem autem omnis consequatur est itaque.", 9.879915486416920m, 343.80m, "Unbranded Fresh Towels" });
        }
    }
}
