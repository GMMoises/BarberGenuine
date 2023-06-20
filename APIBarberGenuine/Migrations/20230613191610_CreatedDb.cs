using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIBarberGenuine.Migrations
{
    public partial class CreatedDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameProduct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PriceUnit = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    UnitInStock = table.Column<int>(type: "int", nullable: false),
                    Providers = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Citas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Service = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dates = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Citas_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "LastName", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, "Gallegos", "Moises", "76130819" },
                    { 2, "Oviedo", "Mateo", "81133691" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "NameProduct", "PriceUnit", "Providers", "UnitInStock" },
                values: new object[,]
                {
                    { 1, "CeraSpider", 50m, "Ceras S.A", 100 },
                    { 2, "Gel EGO", 25m, "eGo", 100 },
                    { 3, "Crema Sedal", 15m, "Sedal", 100 }
                });

            migrationBuilder.InsertData(
                table: "Citas",
                columns: new[] { "Id", "ClientId", "Dates", "Service" },
                values: new object[] { 1, 1, new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Corte" });

            migrationBuilder.InsertData(
                table: "Citas",
                columns: new[] { "Id", "ClientId", "Dates", "Service" },
                values: new object[] { 2, 2, new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Barba" });

            migrationBuilder.InsertData(
                table: "Citas",
                columns: new[] { "Id", "ClientId", "Dates", "Service" },
                values: new object[] { 3, 1, new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Barba" });

            migrationBuilder.CreateIndex(
                name: "IX_Citas_ClientId",
                table: "Citas",
                column: "ClientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Citas");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
