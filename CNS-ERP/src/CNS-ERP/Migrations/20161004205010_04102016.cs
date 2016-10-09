using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CNSSERP.DAL.Migrations
{
    public partial class _04102016 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "StoragesDbSet",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "StoragesDbSet",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Suite",
                table: "StoragesDbSet",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "StoragesDbSet");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "StoragesDbSet");

            migrationBuilder.AlterColumn<string>(
                name: "Suite",
                table: "StoragesDbSet",
                nullable: false);
        }
    }
}
