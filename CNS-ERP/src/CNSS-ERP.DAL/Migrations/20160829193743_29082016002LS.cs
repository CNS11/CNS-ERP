using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CNSSERP.DAL.Migrations
{
    public partial class _29082016002LS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_documentsDbSet_Customers_CustomersRefId",
                table: "Purchase_documentsDbSet");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_invoicesDbSet_Customers_CustomersRefId",
                table: "Sales_invoicesDbSet");

            migrationBuilder.DropIndex(
                name: "IX_Sales_invoicesDbSet_CustomersRefId",
                table: "Sales_invoicesDbSet");

            migrationBuilder.DropIndex(
                name: "IX_Purchase_documentsDbSet_CustomersRefId",
                table: "Purchase_documentsDbSet");

            migrationBuilder.DropColumn(
                name: "CustomersRefId",
                table: "Sales_invoicesDbSet");

            migrationBuilder.DropColumn(
                name: "CustomersRefId",
                table: "Purchase_documentsDbSet");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.CreateTable(
                name: "Contractors",
                columns: table => new
                {
                    ContractorsId = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    Postal_code = table.Column<string>(nullable: false),
                    Street = table.Column<string>(nullable: false),
                    Street_address = table.Column<string>(nullable: false),
                    Suite = table.Column<string>(nullable: false),
                    Vat_number = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contractors", x => x.ContractorsId);
                });

            migrationBuilder.AddColumn<string>(
                name: "ContractorsRefId",
                table: "Sales_invoicesDbSet",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ContractorsRefId",
                table: "Purchase_documentsDbSet",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_invoicesDbSet_ContractorsRefId",
                table: "Sales_invoicesDbSet",
                column: "ContractorsRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_documentsDbSet_ContractorsRefId",
                table: "Purchase_documentsDbSet",
                column: "ContractorsRefId");

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_documentsDbSet_Contractors_ContractorsRefId",
                table: "Purchase_documentsDbSet",
                column: "ContractorsRefId",
                principalTable: "Contractors",
                principalColumn: "ContractorsId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_invoicesDbSet_Contractors_ContractorsRefId",
                table: "Sales_invoicesDbSet",
                column: "ContractorsRefId",
                principalTable: "Contractors",
                principalColumn: "ContractorsId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_documentsDbSet_Contractors_ContractorsRefId",
                table: "Purchase_documentsDbSet");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_invoicesDbSet_Contractors_ContractorsRefId",
                table: "Sales_invoicesDbSet");

            migrationBuilder.DropIndex(
                name: "IX_Sales_invoicesDbSet_ContractorsRefId",
                table: "Sales_invoicesDbSet");

            migrationBuilder.DropIndex(
                name: "IX_Purchase_documentsDbSet_ContractorsRefId",
                table: "Purchase_documentsDbSet");

            migrationBuilder.DropColumn(
                name: "ContractorsRefId",
                table: "Sales_invoicesDbSet");

            migrationBuilder.DropColumn(
                name: "ContractorsRefId",
                table: "Purchase_documentsDbSet");

            migrationBuilder.DropTable(
                name: "Contractors");

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomersId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomersId);
                });

            migrationBuilder.AddColumn<string>(
                name: "CustomersRefId",
                table: "Sales_invoicesDbSet",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CustomersRefId",
                table: "Purchase_documentsDbSet",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_invoicesDbSet_CustomersRefId",
                table: "Sales_invoicesDbSet",
                column: "CustomersRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_documentsDbSet_CustomersRefId",
                table: "Purchase_documentsDbSet",
                column: "CustomersRefId");

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_documentsDbSet_Customers_CustomersRefId",
                table: "Purchase_documentsDbSet",
                column: "CustomersRefId",
                principalTable: "Customers",
                principalColumn: "CustomersId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_invoicesDbSet_Customers_CustomersRefId",
                table: "Sales_invoicesDbSet",
                column: "CustomersRefId",
                principalTable: "Customers",
                principalColumn: "CustomersId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
