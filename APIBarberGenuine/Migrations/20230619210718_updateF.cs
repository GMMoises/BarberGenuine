using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIBarberGenuine.Migrations
{
    public partial class updateF : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SoldUnits",
                table: "Facturas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Facturas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fecha", "SoldUnits", "Total" },
                values: new object[] { new DateTime(2023, 6, 19, 15, 7, 18, 633, DateTimeKind.Local).AddTicks(3346), 3, 150m });

            migrationBuilder.UpdateData(
                table: "Facturas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Fecha", "SoldUnits", "Total" },
                values: new object[] { new DateTime(2023, 6, 19, 15, 7, 18, 633, DateTimeKind.Local).AddTicks(3356), 2, 50m });

            migrationBuilder.UpdateData(
                table: "Facturas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Fecha", "SoldUnits", "Total" },
                values: new object[] { new DateTime(2023, 6, 19, 15, 7, 18, 633, DateTimeKind.Local).AddTicks(3357), 3, 45m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SoldUnits",
                table: "Facturas");

            migrationBuilder.UpdateData(
                table: "Facturas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fecha", "Total" },
                values: new object[] { new DateTime(2023, 6, 19, 9, 43, 54, 342, DateTimeKind.Local).AddTicks(4459), 0m });

            migrationBuilder.UpdateData(
                table: "Facturas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Fecha", "Total" },
                values: new object[] { new DateTime(2023, 6, 19, 9, 43, 54, 342, DateTimeKind.Local).AddTicks(4471), 0m });

            migrationBuilder.UpdateData(
                table: "Facturas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Fecha", "Total" },
                values: new object[] { new DateTime(2023, 6, 19, 9, 43, 54, 342, DateTimeKind.Local).AddTicks(4471), 0m });
        }
    }
}
