using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 17, 6, 18, 471, DateTimeKind.Local).AddTicks(2971), "Black", "System", new DateTime(2024, 11, 18, 17, 6, 18, 471, DateTimeKind.Local).AddTicks(2980) },
                    { 2, "System", new DateTime(2024, 11, 18, 17, 6, 18, 471, DateTimeKind.Local).AddTicks(2982), "Blue", "System", new DateTime(2024, 11, 18, 17, 6, 18, 471, DateTimeKind.Local).AddTicks(2983) }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 17, 6, 18, 471, DateTimeKind.Local).AddTicks(3122), "BMW", "System", new DateTime(2024, 11, 18, 17, 6, 18, 471, DateTimeKind.Local).AddTicks(3123) },
                    { 2, "System", new DateTime(2024, 11, 18, 17, 6, 18, 471, DateTimeKind.Local).AddTicks(3125), "Toyota", "System", new DateTime(2024, 11, 18, 17, 6, 18, 471, DateTimeKind.Local).AddTicks(3126) }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 17, 6, 18, 471, DateTimeKind.Local).AddTicks(3216), "i4", "System", new DateTime(2024, 11, 18, 17, 6, 18, 471, DateTimeKind.Local).AddTicks(3217) },
                    { 2, "System", new DateTime(2024, 11, 18, 17, 6, 18, 471, DateTimeKind.Local).AddTicks(3219), "X5", "System", new DateTime(2024, 11, 18, 17, 6, 18, 471, DateTimeKind.Local).AddTicks(3219) },
                    { 3, "System", new DateTime(2024, 11, 18, 17, 6, 18, 471, DateTimeKind.Local).AddTicks(3221), "Prius", "System", new DateTime(2024, 11, 18, 17, 6, 18, 471, DateTimeKind.Local).AddTicks(3221) },
                    { 4, "System", new DateTime(2024, 11, 18, 17, 6, 18, 471, DateTimeKind.Local).AddTicks(3223), "C-HR", "System", new DateTime(2024, 11, 18, 17, 6, 18, 471, DateTimeKind.Local).AddTicks(3224) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
