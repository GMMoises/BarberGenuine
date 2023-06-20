using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIBarberGenuine.Migrations
{
    public partial class UpdateP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Facturas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2023, 6, 19, 21, 30, 35, 832, DateTimeKind.Local).AddTicks(4536));

            migrationBuilder.UpdateData(
                table: "Facturas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2023, 6, 19, 21, 30, 35, 832, DateTimeKind.Local).AddTicks(4545));

            migrationBuilder.UpdateData(
                table: "Facturas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2023, 6, 19, 21, 30, 35, 832, DateTimeKind.Local).AddTicks(4545));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "FacturaId", "NameProduct", "PriceUnit", "Providers", "UnitInStock" },
                values: new object[,]
                {
                    { 4, 3, "XTREME", 15m, "Belleza S.A", 460 },
                    { 5, 3, "Shampoo Sedal", 20m, "Sedal", 300 },
                    { 6, 3, "CeraXtreme", 45m, "Belleza S.A", 300 },
                    { 7, 3, "Fijador EGO", 60m, "eGo", 240 },
                    { 8, 3, "Crema Pert", 30m, "Schwarzkpf", 100 },
                    { 9, 3, "Seda Rizos", 15m, "Sedal", 600 },
                    { 10, 3, "Cera vol.10", 30m, "Cera's S.A", 250 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Facturas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2023, 6, 19, 15, 7, 18, 633, DateTimeKind.Local).AddTicks(3346));

            migrationBuilder.UpdateData(
                table: "Facturas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2023, 6, 19, 15, 7, 18, 633, DateTimeKind.Local).AddTicks(3356));

            migrationBuilder.UpdateData(
                table: "Facturas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2023, 6, 19, 15, 7, 18, 633, DateTimeKind.Local).AddTicks(3357));
        }
    }
}
