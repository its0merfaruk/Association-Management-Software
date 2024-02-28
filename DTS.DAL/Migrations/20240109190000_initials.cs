using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DTS.DAL.Migrations
{
    public partial class initials : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aidatlars",
                columns: table => new
                {
                    AidatlarID = table.Column<int>(nullable: false)
                        .Annotation("Jet:Identity", "1, 1"),
                    TC_Kimlik = table.Column<string>(nullable: false),
                    Ay = table.Column<string>(nullable: false),
                    Yil = table.Column<string>(nullable: false),
                    Aidat_Tutari = table.Column<string>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aidatlars", x => x.AidatlarID);
                });

            migrationBuilder.CreateTable(
                name: "Odemelers",
                columns: table => new
                {
                    OdemelerID = table.Column<int>(nullable: false)
                        .Annotation("Jet:Identity", "1, 1"),
                    TC_Kimlik = table.Column<string>(nullable: false),
                    AidatlarID = table.Column<string>(nullable: false),
                    Odenen_Tutar = table.Column<string>(nullable: false),
                    Odeme_Tarihi = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Odemelers", x => x.OdemelerID);
                });

            migrationBuilder.CreateTable(
                name: "Uyelers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Jet:Identity", "1, 1"),
                    TC_Kimlik = table.Column<string>(nullable: false),
                    Adi = table.Column<string>(nullable: false),
                    Soyadi = table.Column<string>(nullable: false),
                    Sehir = table.Column<string>(nullable: false),
                    Kan_Grubu = table.Column<string>(nullable: false),
                    Aktif = table.Column<bool>(nullable: false),
                    Dogum_Tarihi = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    AidatlarID = table.Column<int>(nullable: false),
                    OdemelerID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uyelers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Uyelers_Aidatlars_AidatlarID",
                        column: x => x.AidatlarID,
                        principalTable: "Aidatlars",
                        principalColumn: "AidatlarID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Uyelers_Odemelers_OdemelerID",
                        column: x => x.OdemelerID,
                        principalTable: "Odemelers",
                        principalColumn: "OdemelerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Uyelers_AidatlarID",
                table: "Uyelers",
                column: "AidatlarID");

            migrationBuilder.CreateIndex(
                name: "IX_Uyelers_OdemelerID",
                table: "Uyelers",
                column: "OdemelerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Uyelers");

            migrationBuilder.DropTable(
                name: "Aidatlars");

            migrationBuilder.DropTable(
                name: "Odemelers");
        }
    }
}
