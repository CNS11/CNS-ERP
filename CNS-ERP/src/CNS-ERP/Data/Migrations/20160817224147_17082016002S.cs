using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CNS_ERP.Data.Migrations
{
    public partial class _17082016002S : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InformacjeUzytkownikaDbSet_AspNetUsers_PracownikRefLogin",
                table: "InformacjeUzytkownikaDbSet");

            migrationBuilder.DropIndex(
                name: "IX_InformacjeUzytkownikaDbSet_PracownikRefLogin",
                table: "InformacjeUzytkownikaDbSet");

            migrationBuilder.DropColumn(
                name: "PracownikRefLogin",
                table: "InformacjeUzytkownikaDbSet");

            migrationBuilder.AddColumn<int>(
                name: "InformacjeUzytkownikaId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_InformacjeUzytkownikaId",
                table: "AspNetUsers",
                column: "InformacjeUzytkownikaId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_InformacjeUzytkownikaDbSet_InformacjeUzytkownikaId",
                table: "AspNetUsers",
                column: "InformacjeUzytkownikaId",
                principalTable: "InformacjeUzytkownikaDbSet",
                principalColumn: "InformacjeUzytkownikaId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_InformacjeUzytkownikaDbSet_InformacjeUzytkownikaId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_InformacjeUzytkownikaId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "InformacjeUzytkownikaId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "PracownikRefLogin",
                table: "InformacjeUzytkownikaDbSet",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_InformacjeUzytkownikaDbSet_PracownikRefLogin",
                table: "InformacjeUzytkownikaDbSet",
                column: "PracownikRefLogin",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_InformacjeUzytkownikaDbSet_AspNetUsers_PracownikRefLogin",
                table: "InformacjeUzytkownikaDbSet",
                column: "PracownikRefLogin",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
