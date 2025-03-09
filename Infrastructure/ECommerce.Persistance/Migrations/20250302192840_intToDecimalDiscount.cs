using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerce.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class intToDecimalDiscount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "Discount",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2025, 3, 2, 19, 28, 39, 453, DateTimeKind.Utc).AddTicks(6257), "Kids, Automotive & Shoes" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2025, 3, 2, 19, 28, 39, 453, DateTimeKind.Utc).AddTicks(6283), "Tools" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2025, 3, 2, 19, 28, 39, 453, DateTimeKind.Utc).AddTicks(6339), "Books, Home & Shoes" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 19, 28, 39, 453, DateTimeKind.Utc).AddTicks(8430));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 19, 28, 39, 453, DateTimeKind.Utc).AddTicks(8432));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 19, 28, 39, 453, DateTimeKind.Utc).AddTicks(8434));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 19, 28, 39, 453, DateTimeKind.Utc).AddTicks(8436));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2025, 3, 2, 19, 28, 39, 455, DateTimeKind.Utc).AddTicks(6701), "Possimus et maxime rem dolor.", "Atque." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2025, 3, 2, 19, 28, 39, 455, DateTimeKind.Utc).AddTicks(6882), "Facilis magni cum impedit et.", "Quia." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2025, 3, 2, 19, 28, 39, 455, DateTimeKind.Utc).AddTicks(7051), "İn voluptas ut ut delectus.", "Et." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2025, 3, 2, 19, 28, 39, 457, DateTimeKind.Utc).AddTicks(8742), "İd ut praesentium quo alias suscipit ducimus dicta doloribus nihil.", 1m, 410.03m, "Handcrafted Metal Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2025, 3, 2, 19, 28, 39, 457, DateTimeKind.Utc).AddTicks(9049), "Optio voluptatem nihil porro dolore aut dolorum qui suscipit aperiam.", 4m, 711.50m, "Intelligent Soft Sausages" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "Products",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "Discount",
                table: "Products",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2025, 2, 28, 9, 46, 57, 369, DateTimeKind.Utc).AddTicks(2705), "Baby, Music & Automotive" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2025, 2, 28, 9, 46, 57, 369, DateTimeKind.Utc).AddTicks(2764), "Computers, Tools & Beauty" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2025, 2, 28, 9, 46, 57, 369, DateTimeKind.Utc).AddTicks(2785), "Beauty" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 9, 46, 57, 369, DateTimeKind.Utc).AddTicks(5270));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 9, 46, 57, 369, DateTimeKind.Utc).AddTicks(5272));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 9, 46, 57, 369, DateTimeKind.Utc).AddTicks(5273));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 9, 46, 57, 369, DateTimeKind.Utc).AddTicks(5275));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2025, 2, 28, 9, 46, 57, 370, DateTimeKind.Utc).AddTicks(9321), "Excepturi pariatur qui quam necessitatibus.", "Consequuntur." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2025, 2, 28, 9, 46, 57, 370, DateTimeKind.Utc).AddTicks(9451), "Vero tempore doloribus error explicabo.", "Cupiditate." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2025, 2, 28, 9, 46, 57, 370, DateTimeKind.Utc).AddTicks(9581), "Ut hic excepturi unde fugit.", "Amet." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2025, 2, 28, 9, 46, 57, 372, DateTimeKind.Utc).AddTicks(7288), "Placeat possimus libero veritatis et dolor est eos molestiae odio.", 0, 599, "Unbranded Rubber Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2025, 2, 28, 9, 46, 57, 372, DateTimeKind.Utc).AddTicks(7512), "Assumenda quae occaecati molestiae occaecati laudantium odit aut quod et.", 3, 534, "Sleek Cotton Bacon" });
        }
    }
}
