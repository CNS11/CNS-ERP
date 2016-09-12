using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CNSSERP.DAL.Migrations
{
    public partial class _12092016001LS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {






            migrationBuilder.CreateTable(
                name: "MovieDbSet",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Director = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieDbSet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StoragesDbSet",
                columns: table => new
                {
                    StorageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    City = table.Column<string>(nullable: false),
                    Postal_code = table.Column<string>(nullable: false),
                    Street = table.Column<string>(nullable: false),
                    Street_address = table.Column<string>(nullable: false),
                    Suite = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoragesDbSet", x => x.StorageId);
                });



            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_positionsDbSet_Tax_ratesDbSet_Tax_ratesRefId",
                table: "Purchase_positionsDbSet",
                column: "Tax_ratesRefId",
                principalTable: "Tax_rates",
                principalColumn: "Tax_ratesId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Receipt_positionsDbSet_Tax_ratesDbSet_Tax_ratesRefId",
                table: "Receipt_positionsDbSet",
                column: "Tax_ratesRefId",
                principalTable: "Tax_rates",
                principalColumn: "Tax_ratesId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsDbSet_Tax_ratesDbSet_Tax_ratesRefId",
                table: "ProductsDbSet",
                column: "Tax_ratesRefId",
                principalTable: "Tax_rates",
                principalColumn: "Tax_ratesId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.RenameTable(
                name: "Tax_rates",
                newName: "Tax_ratesDbSet");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_positionsDbSet_Tax_ratesDbSet_Tax_ratesRefId",
                table: "Purchase_positionsDbSet");

            migrationBuilder.DropForeignKey(
                name: "FK_Receipt_positionsDbSet_Tax_ratesDbSet_Tax_ratesRefId",
                table: "Receipt_positionsDbSet");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductsDbSet_Tax_ratesDbSet_Tax_ratesRefId",
                table: "ProductsDbSet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tax_ratesDbSet",
                table: "Tax_ratesDbSet");

            migrationBuilder.DropTable(
                name: "MovieDbSet");

            migrationBuilder.DropTable(
                name: "StoragesDbSet");

            migrationBuilder.AddColumn<int>(
                name: "Position",
                table: "UserAdditionalInfosDbSet",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tax_rates",
                table: "Tax_ratesDbSet",
                column: "Tax_ratesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_positionsDbSet_Tax_rates_Tax_ratesRefId",
                table: "Purchase_positionsDbSet",
                column: "Tax_ratesRefId",
                principalTable: "Tax_ratesDbSet",
                principalColumn: "Tax_ratesId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Receipt_positionsDbSet_Tax_rates_Tax_ratesRefId",
                table: "Receipt_positionsDbSet",
                column: "Tax_ratesRefId",
                principalTable: "Tax_ratesDbSet",
                principalColumn: "Tax_ratesId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsDbSet_Tax_rates_Tax_ratesRefId",
                table: "ProductsDbSet",
                column: "Tax_ratesRefId",
                principalTable: "Tax_ratesDbSet",
                principalColumn: "Tax_ratesId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.RenameTable(
                name: "Tax_ratesDbSet",
                newName: "Tax_rates");
        }
    }
}
