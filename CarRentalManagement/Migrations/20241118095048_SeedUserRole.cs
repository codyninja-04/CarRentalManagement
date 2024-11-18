using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 42, 45, 836, DateTimeKind.Local).AddTicks(9189), new DateTime(2024, 11, 18, 17, 42, 45, 836, DateTimeKind.Local).AddTicks(9198) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 42, 45, 836, DateTimeKind.Local).AddTicks(9200), new DateTime(2024, 11, 18, 17, 42, 45, 836, DateTimeKind.Local).AddTicks(9200) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 42, 45, 836, DateTimeKind.Local).AddTicks(9336), new DateTime(2024, 11, 18, 17, 42, 45, 836, DateTimeKind.Local).AddTicks(9336) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 42, 45, 836, DateTimeKind.Local).AddTicks(9338), new DateTime(2024, 11, 18, 17, 42, 45, 836, DateTimeKind.Local).AddTicks(9338) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 42, 45, 836, DateTimeKind.Local).AddTicks(9396), new DateTime(2024, 11, 18, 17, 42, 45, 836, DateTimeKind.Local).AddTicks(9396) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 42, 45, 836, DateTimeKind.Local).AddTicks(9398), new DateTime(2024, 11, 18, 17, 42, 45, 836, DateTimeKind.Local).AddTicks(9398) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 42, 45, 836, DateTimeKind.Local).AddTicks(9399), new DateTime(2024, 11, 18, 17, 42, 45, 836, DateTimeKind.Local).AddTicks(9399) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 42, 45, 836, DateTimeKind.Local).AddTicks(9400), new DateTime(2024, 11, 18, 17, 42, 45, 836, DateTimeKind.Local).AddTicks(9401) });
        }
    }
}
