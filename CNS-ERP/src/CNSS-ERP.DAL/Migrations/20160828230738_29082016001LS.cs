using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CNSSERP.DAL.Migrations
{
    public partial class _29082016001LS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropTable(
                name: "InformacjeUzytkownikaDbSet");

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

            migrationBuilder.CreateTable(
                name: "Pay_methodsinvoiceDbSet",
                columns: table => new
                {
                    Pay_methodsinvoiceId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pay_methodsinvoiceDbSet", x => x.Pay_methodsinvoiceId);
                });

            migrationBuilder.CreateTable(
                name: "Pay_methodsreceiptDbSet",
                columns: table => new
                {
                    Pay_methodsreceiptId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pay_methodsreceiptDbSet", x => x.Pay_methodsreceiptId);
                });

            migrationBuilder.CreateTable(
                name: "Tax_rates",
                columns: table => new
                {
                    Tax_ratesId = table.Column<string>(nullable: false),
                    Last_changed_date = table.Column<DateTime>(nullable: false),
                    Number_value = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tax_rates", x => x.Tax_ratesId);
                });

            migrationBuilder.CreateTable(
                name: "Product_categoriesDbSet",
                columns: table => new
                {
                    Product_categoriesId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: false),
                    Level = table.Column<int>(nullable: false),
                    Master_product_categoryRefId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product_categoriesDbSet", x => x.Product_categoriesId);
                    table.ForeignKey(
                        name: "FK_Product_categoriesDbSet_Product_categoriesDbSet_Master_product_categoryRefId",
                        column: x => x.Master_product_categoryRefId,
                        principalTable: "Product_categoriesDbSet",
                        principalColumn: "Product_categoriesId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UnitsDbSet",
                columns: table => new
                {
                    UnitId = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitsDbSet", x => x.UnitId);
                });

            migrationBuilder.CreateTable(
                name: "UserAdditionalInfosDbSet",
                columns: table => new
                {
                    UserAdditionalInfosId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    City = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Position = table.Column<int>(nullable: false),
                    Street = table.Column<string>(nullable: false),
                    Surname = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAdditionalInfosDbSet", x => x.UserAdditionalInfosId);
                });

            migrationBuilder.CreateTable(
                name: "Purchase_documentsDbSet",
                columns: table => new
                {
                    Sales_invoiceId = table.Column<string>(nullable: false),
                    Creation_date = table.Column<DateTime>(nullable: false),
                    CustomersRefId = table.Column<string>(nullable: false),
                    Gross_value = table.Column<decimal>(nullable: false),
                    Net_value = table.Column<decimal>(nullable: false),
                    Pay_methodsRefId = table.Column<string>(nullable: false),
                    Payment_date = table.Column<DateTime>(nullable: false),
                    Tax_value = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchase_documentsDbSet", x => x.Sales_invoiceId);
                    table.ForeignKey(
                        name: "FK_Purchase_documentsDbSet_Customers_CustomersRefId",
                        column: x => x.CustomersRefId,
                        principalTable: "Customers",
                        principalColumn: "CustomersId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Purchase_documentsDbSet_Pay_methodsinvoiceDbSet_Pay_methodsRefId",
                        column: x => x.Pay_methodsRefId,
                        principalTable: "Pay_methodsinvoiceDbSet",
                        principalColumn: "Pay_methodsinvoiceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sales_invoicesDbSet",
                columns: table => new
                {
                    Sales_invoiceId = table.Column<string>(nullable: false),
                    Creation_date = table.Column<DateTime>(nullable: false),
                    CustomersRefId = table.Column<string>(nullable: false),
                    Gross_value = table.Column<decimal>(nullable: false),
                    Net_value = table.Column<decimal>(nullable: false),
                    Pay_methodsRefId = table.Column<string>(nullable: false),
                    Payment_date = table.Column<DateTime>(nullable: false),
                    Tax_value = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales_invoicesDbSet", x => x.Sales_invoiceId);
                    table.ForeignKey(
                        name: "FK_Sales_invoicesDbSet_Customers_CustomersRefId",
                        column: x => x.CustomersRefId,
                        principalTable: "Customers",
                        principalColumn: "CustomersId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sales_invoicesDbSet_Pay_methodsinvoiceDbSet_Pay_methodsRefId",
                        column: x => x.Pay_methodsRefId,
                        principalTable: "Pay_methodsinvoiceDbSet",
                        principalColumn: "Pay_methodsinvoiceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sales_ReceiptsDbSet",
                columns: table => new
                {
                    Sales_receiptId = table.Column<string>(nullable: false),
                    Creation_date = table.Column<DateTime>(nullable: false),
                    Gross_value = table.Column<decimal>(nullable: false),
                    Is_fiscalized = table.Column<bool>(nullable: false),
                    Net_value = table.Column<decimal>(nullable: false),
                    Pay_methodsRefId = table.Column<string>(nullable: false),
                    Print_date = table.Column<DateTime>(nullable: false),
                    Tax_value = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales_ReceiptsDbSet", x => x.Sales_receiptId);
                    table.ForeignKey(
                        name: "FK_Sales_ReceiptsDbSet_Pay_methodsreceiptDbSet_Pay_methodsRefId",
                        column: x => x.Pay_methodsRefId,
                        principalTable: "Pay_methodsreceiptDbSet",
                        principalColumn: "Pay_methodsreceiptId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductsDbSet",
                columns: table => new
                {
                    ProductId = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    EAN_code = table.Column<string>(nullable: false),
                    Product_categoryRefId = table.Column<int>(nullable: false),
                    Tax_ratesRefId = table.Column<string>(nullable: false),
                    UnitsRefId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsDbSet", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_ProductsDbSet_Product_categoriesDbSet_Product_categoryRefId",
                        column: x => x.Product_categoryRefId,
                        principalTable: "Product_categoriesDbSet",
                        principalColumn: "Product_categoriesId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductsDbSet_Tax_rates_Tax_ratesRefId",
                        column: x => x.Tax_ratesRefId,
                        principalTable: "Tax_rates",
                        principalColumn: "Tax_ratesId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductsDbSet_UnitsDbSet_UnitsRefId",
                        column: x => x.UnitsRefId,
                        principalTable: "UnitsDbSet",
                        principalColumn: "UnitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UnitConversionsDbSet",
                columns: table => new
                {
                    UnitConversionsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Precision = table.Column<int>(nullable: false),
                    Units_1RefId = table.Column<string>(nullable: false),
                    Units_2RefId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitConversionsDbSet", x => x.UnitConversionsId);
                    table.ForeignKey(
                        name: "FK_UnitConversionsDbSet_UnitsDbSet_Units_1RefId",
                        column: x => x.Units_1RefId,
                        principalTable: "UnitsDbSet",
                        principalColumn: "UnitId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UnitConversionsDbSet_UnitsDbSet_Units_2RefId",
                        column: x => x.Units_2RefId,
                        principalTable: "UnitsDbSet",
                        principalColumn: "UnitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Purchase_positionsDbSet",
                columns: table => new
                {
                    Purchase_positionsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Gross_value = table.Column<decimal>(nullable: false),
                    Net_price = table.Column<decimal>(nullable: false),
                    Net_value = table.Column<decimal>(nullable: false),
                    ProductsRefId = table.Column<string>(nullable: false),
                    Purchase_documentsRefId = table.Column<string>(nullable: false),
                    Quantity = table.Column<decimal>(nullable: false),
                    Tax_ratesRefId = table.Column<string>(nullable: false),
                    Tax_value = table.Column<decimal>(nullable: false),
                    UnitsRefId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchase_positionsDbSet", x => x.Purchase_positionsId);
                    table.ForeignKey(
                        name: "FK_Purchase_positionsDbSet_ProductsDbSet_ProductsRefId",
                        column: x => x.ProductsRefId,
                        principalTable: "ProductsDbSet",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Purchase_positionsDbSet_Purchase_documentsDbSet_Purchase_documentsRefId",
                        column: x => x.Purchase_documentsRefId,
                        principalTable: "Purchase_documentsDbSet",
                        principalColumn: "Sales_invoiceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Purchase_positionsDbSet_Tax_rates_Tax_ratesRefId",
                        column: x => x.Tax_ratesRefId,
                        principalTable: "Tax_rates",
                        principalColumn: "Tax_ratesId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Purchase_positionsDbSet_UnitsDbSet_UnitsRefId",
                        column: x => x.UnitsRefId,
                        principalTable: "UnitsDbSet",
                        principalColumn: "UnitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Receipt_positionsDbSet",
                columns: table => new
                {
                    Receipt_positionsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Gross_value = table.Column<decimal>(nullable: false),
                    Net_price = table.Column<decimal>(nullable: false),
                    Net_value = table.Column<decimal>(nullable: false),
                    ProductsRefId = table.Column<string>(nullable: false),
                    Quantity = table.Column<decimal>(nullable: false),
                    Sales_receiptsRefId = table.Column<string>(nullable: false),
                    Tax_ratesRefId = table.Column<string>(nullable: false),
                    Tax_value = table.Column<decimal>(nullable: false),
                    UnitsRefId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receipt_positionsDbSet", x => x.Receipt_positionsId);
                    table.ForeignKey(
                        name: "FK_Receipt_positionsDbSet_ProductsDbSet_ProductsRefId",
                        column: x => x.ProductsRefId,
                        principalTable: "ProductsDbSet",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Receipt_positionsDbSet_Sales_ReceiptsDbSet_Sales_receiptsRefId",
                        column: x => x.Sales_receiptsRefId,
                        principalTable: "Sales_ReceiptsDbSet",
                        principalColumn: "Sales_receiptId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Receipt_positionsDbSet_Tax_rates_Tax_ratesRefId",
                        column: x => x.Tax_ratesRefId,
                        principalTable: "Tax_rates",
                        principalColumn: "Tax_ratesId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Receipt_positionsDbSet_UnitsDbSet_UnitsRefId",
                        column: x => x.UnitsRefId,
                        principalTable: "UnitsDbSet",
                        principalColumn: "UnitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.AddColumn<int>(
                name: "UserAdditionalInfosId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_UserAdditionalInfosId",
                table: "AspNetUsers",
                column: "UserAdditionalInfosId");

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_documentsDbSet_CustomersRefId",
                table: "Purchase_documentsDbSet",
                column: "CustomersRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_documentsDbSet_Pay_methodsRefId",
                table: "Purchase_documentsDbSet",
                column: "Pay_methodsRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_positionsDbSet_ProductsRefId",
                table: "Purchase_positionsDbSet",
                column: "ProductsRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_positionsDbSet_Purchase_documentsRefId",
                table: "Purchase_positionsDbSet",
                column: "Purchase_documentsRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_positionsDbSet_Tax_ratesRefId",
                table: "Purchase_positionsDbSet",
                column: "Tax_ratesRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_positionsDbSet_UnitsRefId",
                table: "Purchase_positionsDbSet",
                column: "UnitsRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Receipt_positionsDbSet_ProductsRefId",
                table: "Receipt_positionsDbSet",
                column: "ProductsRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Receipt_positionsDbSet_Sales_receiptsRefId",
                table: "Receipt_positionsDbSet",
                column: "Sales_receiptsRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Receipt_positionsDbSet_Tax_ratesRefId",
                table: "Receipt_positionsDbSet",
                column: "Tax_ratesRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Receipt_positionsDbSet_UnitsRefId",
                table: "Receipt_positionsDbSet",
                column: "UnitsRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_invoicesDbSet_CustomersRefId",
                table: "Sales_invoicesDbSet",
                column: "CustomersRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_invoicesDbSet_Pay_methodsRefId",
                table: "Sales_invoicesDbSet",
                column: "Pay_methodsRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_ReceiptsDbSet_Pay_methodsRefId",
                table: "Sales_ReceiptsDbSet",
                column: "Pay_methodsRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_categoriesDbSet_Master_product_categoryRefId",
                table: "Product_categoriesDbSet",
                column: "Master_product_categoryRefId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsDbSet_Product_categoryRefId",
                table: "ProductsDbSet",
                column: "Product_categoryRefId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsDbSet_Tax_ratesRefId",
                table: "ProductsDbSet",
                column: "Tax_ratesRefId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsDbSet_UnitsRefId",
                table: "ProductsDbSet",
                column: "UnitsRefId");

            migrationBuilder.CreateIndex(
                name: "IX_UnitConversionsDbSet_Units_1RefId",
                table: "UnitConversionsDbSet",
                column: "Units_1RefId");

            migrationBuilder.CreateIndex(
                name: "IX_UnitConversionsDbSet_Units_2RefId",
                table: "UnitConversionsDbSet",
                column: "Units_2RefId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_UserAdditionalInfosDbSet_UserAdditionalInfosId",
                table: "AspNetUsers",
                column: "UserAdditionalInfosId",
                principalTable: "UserAdditionalInfosDbSet",
                principalColumn: "UserAdditionalInfosId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_UserAdditionalInfosDbSet_UserAdditionalInfosId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_UserAdditionalInfosId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserAdditionalInfosId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Purchase_positionsDbSet");

            migrationBuilder.DropTable(
                name: "Receipt_positionsDbSet");

            migrationBuilder.DropTable(
                name: "Sales_invoicesDbSet");

            migrationBuilder.DropTable(
                name: "UnitConversionsDbSet");

            migrationBuilder.DropTable(
                name: "UserAdditionalInfosDbSet");

            migrationBuilder.DropTable(
                name: "Purchase_documentsDbSet");

            migrationBuilder.DropTable(
                name: "ProductsDbSet");

            migrationBuilder.DropTable(
                name: "Sales_ReceiptsDbSet");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Pay_methodsinvoiceDbSet");

            migrationBuilder.DropTable(
                name: "Product_categoriesDbSet");

            migrationBuilder.DropTable(
                name: "Tax_rates");

            migrationBuilder.DropTable(
                name: "UnitsDbSet");

            migrationBuilder.DropTable(
                name: "Pay_methodsreceiptDbSet");

            migrationBuilder.CreateTable(
                name: "InformacjeUzytkownikaDbSet",
                columns: table => new
                {
                    InformacjeUzytkownikaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Imie = table.Column<string>(nullable: false),
                    Miasto = table.Column<string>(nullable: false),
                    Nazwisko = table.Column<string>(nullable: false),
                    Stanowisko = table.Column<int>(nullable: false),
                    Ulica = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InformacjeUzytkownikaDbSet", x => x.InformacjeUzytkownikaId);
                });

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
    }
}
