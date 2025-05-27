using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Laba10.Migrations
{
    /// <inheritdoc />
    public partial class Migr1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abonents",
                columns: table => new
                {
                    AbonentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Familiya = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Imya = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Otchestvo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abonents", x => x.AbonentId);
                });

            migrationBuilder.CreateTable(
                name: "Schetchiks",
                columns: table => new
                {
                    SchetchikId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomerSchetchika = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipSchetchika = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataUstanovki = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AbonentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schetchiks", x => x.SchetchikId);
                    table.ForeignKey(
                        name: "FK_Schetchiks_Abonents_AbonentId",
                        column: x => x.AbonentId,
                        principalTable: "Abonents",
                        principalColumn: "AbonentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pokazanies",
                columns: table => new
                {
                    PokazanieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataPokazaniya = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ZnacheniePokazaniya = table.Column<float>(type: "real", nullable: false),
                    SchetchikId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokazanies", x => x.PokazanieId);
                    table.ForeignKey(
                        name: "FK_Pokazanies_Schetchiks_SchetchikId",
                        column: x => x.SchetchikId,
                        principalTable: "Schetchiks",
                        principalColumn: "SchetchikId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pokazanies_SchetchikId",
                table: "Pokazanies",
                column: "SchetchikId");

            migrationBuilder.CreateIndex(
                name: "IX_Schetchiks_AbonentId",
                table: "Schetchiks",
                column: "AbonentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pokazanies");

            migrationBuilder.DropTable(
                name: "Schetchiks");

            migrationBuilder.DropTable(
                name: "Abonents");
        }
    }
}
