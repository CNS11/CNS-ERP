using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CNS_ERP.Data.Migrations
{
    public partial class _17082016001S : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InformacjeUzytkownikaDbSet",
                columns: table => new
                {
                    InformacjeUzytkownikaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Imie = table.Column<string>(nullable: false),
                    Miasto = table.Column<string>(nullable: false),
                    Nazwisko = table.Column<string>(nullable: false),
                    PracownikRefLogin = table.Column<string>(nullable: false),
                    Stanowisko = table.Column<int>(nullable: false),
                    Ulica = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InformacjeUzytkownikaDbSet", x => x.InformacjeUzytkownikaId);
                    table.ForeignKey(
                        name: "FK_InformacjeUzytkownikaDbSet_AspNetUsers_PracownikRefLogin",
                        column: x => x.PracownikRefLogin,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InformacjeUzytkownikaDbSet_PracownikRefLogin",
                table: "InformacjeUzytkownikaDbSet",
                column: "PracownikRefLogin",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InformacjeUzytkownikaDbSet");
        }
    }
}
