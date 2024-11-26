using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 19, 10, 31, 40, 144, DateTimeKind.Local).AddTicks(4212), new DateTime(2024, 11, 19, 10, 31, 40, 144, DateTimeKind.Local).AddTicks(4228) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 19, 10, 31, 40, 144, DateTimeKind.Local).AddTicks(4231), new DateTime(2024, 11, 19, 10, 31, 40, 144, DateTimeKind.Local).AddTicks(4232) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 19, 10, 31, 40, 144, DateTimeKind.Local).AddTicks(4507), new DateTime(2024, 11, 19, 10, 31, 40, 144, DateTimeKind.Local).AddTicks(4508) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 19, 10, 31, 40, 144, DateTimeKind.Local).AddTicks(4511), new DateTime(2024, 11, 19, 10, 31, 40, 144, DateTimeKind.Local).AddTicks(4511) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 19, 10, 31, 40, 144, DateTimeKind.Local).AddTicks(4620), new DateTime(2024, 11, 19, 10, 31, 40, 144, DateTimeKind.Local).AddTicks(4621) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 19, 10, 31, 40, 144, DateTimeKind.Local).AddTicks(4624), new DateTime(2024, 11, 19, 10, 31, 40, 144, DateTimeKind.Local).AddTicks(4625) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 19, 10, 31, 40, 144, DateTimeKind.Local).AddTicks(4627), new DateTime(2024, 11, 19, 10, 31, 40, 144, DateTimeKind.Local).AddTicks(4628) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 19, 10, 31, 40, 144, DateTimeKind.Local).AddTicks(4630), new DateTime(2024, 11, 19, 10, 31, 40, 144, DateTimeKind.Local).AddTicks(4631) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 50, 48, 265, DateTimeKind.Local).AddTicks(253), new DateTime(2024, 11, 18, 17, 50, 48, 265, DateTimeKind.Local).AddTicks(262) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 50, 48, 265, DateTimeKind.Local).AddTicks(264), new DateTime(2024, 11, 18, 17, 50, 48, 265, DateTimeKind.Local).AddTicks(265) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 50, 48, 265, DateTimeKind.Local).AddTicks(407), new DateTime(2024, 11, 18, 17, 50, 48, 265, DateTimeKind.Local).AddTicks(408) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 50, 48, 265, DateTimeKind.Local).AddTicks(410), new DateTime(2024, 11, 18, 17, 50, 48, 265, DateTimeKind.Local).AddTicks(410) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 50, 48, 265, DateTimeKind.Local).AddTicks(473), new DateTime(2024, 11, 18, 17, 50, 48, 265, DateTimeKind.Local).AddTicks(473) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 50, 48, 265, DateTimeKind.Local).AddTicks(475), new DateTime(2024, 11, 18, 17, 50, 48, 265, DateTimeKind.Local).AddTicks(475) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 50, 48, 265, DateTimeKind.Local).AddTicks(476), new DateTime(2024, 11, 18, 17, 50, 48, 265, DateTimeKind.Local).AddTicks(477) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 50, 48, 265, DateTimeKind.Local).AddTicks(478), new DateTime(2024, 11, 18, 17, 50, 48, 265, DateTimeKind.Local).AddTicks(478) });
        }
    }
}
