using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hurtownia.Migrations
{
    public partial class Startowa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Klients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imie = table.Column<string>(nullable: true),
                    Nazwisko = table.Column<string>(nullable: true),
                    Adres = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Producents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(nullable: true),
                    Tel = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produkts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_producent = table.Column<int>(nullable: false),
                    Nazwa = table.Column<string>(nullable: true),
                    Ilosc = table.Column<int>(nullable: false),
                    ProducentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produkts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produkts_Producents_ProducentId",
                        column: x => x.ProducentId,
                        principalTable: "Producents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Zamowienias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KlientId = table.Column<int>(nullable: true),
                    ProduktId = table.Column<int>(nullable: true),
                    Data = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zamowienias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Zamowienias_Klients_KlientId",
                        column: x => x.KlientId,
                        principalTable: "Klients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Zamowienias_Produkts_ProduktId",
                        column: x => x.ProduktId,
                        principalTable: "Produkts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produkts_ProducentId",
                table: "Produkts",
                column: "ProducentId");

            migrationBuilder.CreateIndex(
                name: "IX_Zamowienias_KlientId",
                table: "Zamowienias",
                column: "KlientId");

            migrationBuilder.CreateIndex(
                name: "IX_Zamowienias_ProduktId",
                table: "Zamowienias",
                column: "ProduktId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Zamowienias");

            migrationBuilder.DropTable(
                name: "Klients");

            migrationBuilder.DropTable(
                name: "Produkts");

            migrationBuilder.DropTable(
                name: "Producents");
        }
    }
}
