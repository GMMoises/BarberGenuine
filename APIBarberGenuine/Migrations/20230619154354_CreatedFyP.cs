using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIBarberGenuine.Migrations
{
    public partial class CreatedFyP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FacturaId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Facturas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facturas", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Facturas",
                columns: new[] { "Id", "Description", "Fecha", "Total" },
                values: new object[] { 1, "Venta", new DateTime(2023, 6, 19, 9, 43, 54, 342, DateTimeKind.Local).AddTicks(4459), 0m });

            migrationBuilder.InsertData(
                table: "Facturas",
                columns: new[] { "Id", "Description", "Fecha", "Total" },
                values: new object[] { 2, "Venta", new DateTime(2023, 6, 19, 9, 43, 54, 342, DateTimeKind.Local).AddTicks(4471), 0m });

            migrationBuilder.InsertData(
                table: "Facturas",
                columns: new[] { "Id", "Description", "Fecha", "Total" },
                values: new object[] { 3, "Venta", new DateTime(2023, 6, 19, 9, 43, 54, 342, DateTimeKind.Local).AddTicks(4471), 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "FacturaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "FacturaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "FacturaId",
                value: 3);

            migrationBuilder.CreateIndex(
                name: "IX_Products_FacturaId",
                table: "Products",
                column: "FacturaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Facturas_FacturaId",
                table: "Products",
                column: "FacturaId",
                principalTable: "Facturas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Facturas_FacturaId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Facturas");

            migrationBuilder.DropIndex(
                name: "IX_Products_FacturaId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "FacturaId",
                table: "Products");
        }
    }
}
