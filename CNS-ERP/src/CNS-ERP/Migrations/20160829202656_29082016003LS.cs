using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CNSSERP.DAL.Migrations
{
    public partial class _29082016003LS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_documentsDbSet_Contractors_ContractorsRefId",
                table: "Purchase_documentsDbSet");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_invoicesDbSet_Contractors_ContractorsRefId",
                table: "Sales_invoicesDbSet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contractors",
                table: "Contractors");

            migrationBuilder.CreateTable(
                name: "Invoice_posiotionsDbSet",
                columns: table => new
                {
                    Invoice_posiotionsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Gross_value = table.Column<decimal>(nullable: false),
                    Net_price = table.Column<decimal>(nullable: false),
                    Net_value = table.Column<decimal>(nullable: false),
                    ProductsRefId = table.Column<string>(nullable: false),
                    Quantity = table.Column<decimal>(nullable: false),
                    Sales_invoicesRefId = table.Column<string>(nullable: false),
                    Tax_ratesRefId = table.Column<string>(nullable: false),
                    Tax_value = table.Column<decimal>(nullable: false),
                    UnitsRefId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoice_posiotionsDbSet", x => x.Invoice_posiotionsId);
                    table.ForeignKey(
                        name: "FK_Invoice_posiotionsDbSet_ProductsDbSet_ProductsRefId",
                        column: x => x.ProductsRefId,
                        principalTable: "ProductsDbSet",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Invoice_posiotionsDbSet_Sales_invoicesDbSet_Sales_invoicesRefId",
                        column: x => x.Sales_invoicesRefId,
                        principalTable: "Sales_invoicesDbSet",
                        principalColumn: "Sales_invoiceId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Invoice_posiotionsDbSet_Tax_rates_Tax_ratesRefId",
                        column: x => x.Tax_ratesRefId,
                        principalTable: "Tax_rates",
                        principalColumn: "Tax_ratesId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Invoice_posiotionsDbSet_UnitsDbSet_UnitsRefId",
                        column: x => x.UnitsRefId,
                        principalTable: "UnitsDbSet",
                        principalColumn: "UnitId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ProductImagesDbSet",
                columns: table => new
                {
                    ProductImagesId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Image = table.Column<byte[]>(nullable: false),
                    ProductsRefId = table.Column<string>(nullable: false),
                    Uploaded_date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImagesDbSet", x => x.ProductImagesId);
                    table.ForeignKey(
                        name: "FK_ProductImagesDbSet_ProductsDbSet_ProductsRefId",
                        column: x => x.ProductsRefId,
                        principalTable: "ProductsDbSet",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductStoragesDbSet",
                columns: table => new
                {
                    ProductStoragesId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductsRefId = table.Column<string>(nullable: false),
                    Quantity = table.Column<decimal>(nullable: false),
                    UnitsRefId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductStoragesDbSet", x => x.ProductStoragesId);
                    table.ForeignKey(
                        name: "FK_ProductStoragesDbSet_ProductsDbSet_ProductsRefId",
                        column: x => x.ProductsRefId,
                        principalTable: "ProductsDbSet",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductStoragesDbSet_UnitsDbSet_UnitsRefId",
                        column: x => x.UnitsRefId,
                        principalTable: "UnitsDbSet",
                        principalColumn: "UnitId",
                        onDelete: ReferentialAction.NoAction);
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

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContractorsDbSet",
                table: "Contractors",
                column: "ContractorsId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_posiotionsDbSet_ProductsRefId",
                table: "Invoice_posiotionsDbSet",
                column: "ProductsRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_posiotionsDbSet_Sales_invoicesRefId",
                table: "Invoice_posiotionsDbSet",
                column: "Sales_invoicesRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_posiotionsDbSet_Tax_ratesRefId",
                table: "Invoice_posiotionsDbSet",
                column: "Tax_ratesRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_posiotionsDbSet_UnitsRefId",
                table: "Invoice_posiotionsDbSet",
                column: "UnitsRefId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImagesDbSet_ProductsRefId",
                table: "ProductImagesDbSet",
                column: "ProductsRefId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductStoragesDbSet_ProductsRefId",
                table: "ProductStoragesDbSet",
                column: "ProductsRefId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductStoragesDbSet_UnitsRefId",
                table: "ProductStoragesDbSet",
                column: "UnitsRefId");

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_documentsDbSet_ContractorsDbSet_ContractorsRefId",
                table: "Purchase_documentsDbSet",
                column: "ContractorsRefId",
                principalTable: "Contractors",
                principalColumn: "ContractorsId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_invoicesDbSet_ContractorsDbSet_ContractorsRefId",
                table: "Sales_invoicesDbSet",
                column: "ContractorsRefId",
                principalTable: "Contractors",
                principalColumn: "ContractorsId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.RenameTable(
                name: "Contractors",
                newName: "ContractorsDbSet");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_documentsDbSet_ContractorsDbSet_ContractorsRefId",
                table: "Purchase_documentsDbSet");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_invoicesDbSet_ContractorsDbSet_ContractorsRefId",
                table: "Sales_invoicesDbSet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContractorsDbSet",
                table: "ContractorsDbSet");

            migrationBuilder.DropTable(
                name: "Invoice_posiotionsDbSet");

            migrationBuilder.DropTable(
                name: "ProductImagesDbSet");

            migrationBuilder.DropTable(
                name: "ProductStoragesDbSet");

            migrationBuilder.DropTable(
                name: "StoragesDbSet");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contractors",
                table: "ContractorsDbSet",
                column: "ContractorsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_documentsDbSet_Contractors_ContractorsRefId",
                table: "Purchase_documentsDbSet",
                column: "ContractorsRefId",
                principalTable: "ContractorsDbSet",
                principalColumn: "ContractorsId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_invoicesDbSet_Contractors_ContractorsRefId",
                table: "Sales_invoicesDbSet",
                column: "ContractorsRefId",
                principalTable: "ContractorsDbSet",
                principalColumn: "ContractorsId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.RenameTable(
                name: "ContractorsDbSet",
                newName: "Contractors");
        }
    }
}
