using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using CNSS_ERP.DAL;

namespace CNSSERP.DAL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CNSS_ERP.DAL.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedUserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<int?>("UserAdditionalInfosId");

                    b.Property<string>("UserName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.HasIndex("UserAdditionalInfosId");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("CNSS_ERP.DAL.Models.Purchase.Purchase_documents", b =>
                {
                    b.Property<string>("Sales_invoiceId");

                    b.Property<string>("ContractorsRefId")
                        .IsRequired();

                    b.Property<DateTime>("Creation_date");

                    b.Property<decimal>("Gross_value");

                    b.Property<decimal>("Net_value");

                    b.Property<string>("Pay_methodsRefId")
                        .IsRequired();

                    b.Property<DateTime>("Payment_date");

                    b.Property<decimal>("Tax_value");

                    b.HasKey("Sales_invoiceId");

                    b.HasIndex("ContractorsRefId");

                    b.HasIndex("Pay_methodsRefId");

                    b.ToTable("Purchase_documentsDbSet");
                });

            modelBuilder.Entity("CNSS_ERP.DAL.Models.Purchase.Purchase_positions", b =>
                {
                    b.Property<int>("Purchase_positionsId")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Gross_value");

                    b.Property<decimal>("Net_price");

                    b.Property<decimal>("Net_value");

                    b.Property<string>("ProductsRefId")
                        .IsRequired();

                    b.Property<string>("Purchase_documentsRefId")
                        .IsRequired();

                    b.Property<decimal>("Quantity");

                    b.Property<string>("Tax_ratesRefId")
                        .IsRequired();

                    b.Property<decimal>("Tax_value");

                    b.Property<string>("UnitsRefId")
                        .IsRequired();

                    b.HasKey("Purchase_positionsId");

                    b.HasIndex("ProductsRefId");

                    b.HasIndex("Purchase_documentsRefId");

                    b.HasIndex("Tax_ratesRefId");

                    b.HasIndex("UnitsRefId");

                    b.ToTable("Purchase_positionsDbSet");
                });

            modelBuilder.Entity("CNSS_ERP.DAL.Models.Sales.Contractors", b =>
                {
                    b.Property<string>("ContractorsId");

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("Postal_code")
                        .IsRequired();

                    b.Property<string>("Street")
                        .IsRequired();

                    b.Property<string>("Street_address")
                        .IsRequired();

                    b.Property<string>("Suite")
                        .IsRequired();

                    b.Property<string>("Vat_number")
                        .IsRequired();

                    b.HasKey("ContractorsId");

                    b.ToTable("Contractors");
                });

            modelBuilder.Entity("CNSS_ERP.DAL.Models.Sales.Pay_methodsinvoice", b =>
                {
                    b.Property<string>("Pay_methodsinvoiceId");

                    b.HasKey("Pay_methodsinvoiceId");

                    b.ToTable("Pay_methodsinvoiceDbSet");
                });

            modelBuilder.Entity("CNSS_ERP.DAL.Models.Sales.Pay_methodsreceipt", b =>
                {
                    b.Property<string>("Pay_methodsreceiptId");

                    b.HasKey("Pay_methodsreceiptId");

                    b.ToTable("Pay_methodsreceiptDbSet");
                });

            modelBuilder.Entity("CNSS_ERP.DAL.Models.Sales.Receipt_positions", b =>
                {
                    b.Property<int>("Receipt_positionsId")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Gross_value");

                    b.Property<decimal>("Net_price");

                    b.Property<decimal>("Net_value");

                    b.Property<string>("ProductsRefId")
                        .IsRequired();

                    b.Property<decimal>("Quantity");

                    b.Property<string>("Sales_receiptsRefId")
                        .IsRequired();

                    b.Property<string>("Tax_ratesRefId")
                        .IsRequired();

                    b.Property<decimal>("Tax_value");

                    b.Property<string>("UnitsRefId")
                        .IsRequired();

                    b.HasKey("Receipt_positionsId");

                    b.HasIndex("ProductsRefId");

                    b.HasIndex("Sales_receiptsRefId");

                    b.HasIndex("Tax_ratesRefId");

                    b.HasIndex("UnitsRefId");

                    b.ToTable("Receipt_positionsDbSet");
                });

            modelBuilder.Entity("CNSS_ERP.DAL.Models.Sales.Sales_invoices", b =>
                {
                    b.Property<string>("Sales_invoiceId");

                    b.Property<string>("ContractorsRefId")
                        .IsRequired();

                    b.Property<DateTime>("Creation_date");

                    b.Property<decimal>("Gross_value");

                    b.Property<decimal>("Net_value");

                    b.Property<string>("Pay_methodsRefId")
                        .IsRequired();

                    b.Property<DateTime>("Payment_date");

                    b.Property<decimal>("Tax_value");

                    b.HasKey("Sales_invoiceId");

                    b.HasIndex("ContractorsRefId");

                    b.HasIndex("Pay_methodsRefId");

                    b.ToTable("Sales_invoicesDbSet");
                });

            modelBuilder.Entity("CNSS_ERP.DAL.Models.Sales.Sales_receipts", b =>
                {
                    b.Property<string>("Sales_receiptId");

                    b.Property<DateTime>("Creation_date");

                    b.Property<decimal>("Gross_value");

                    b.Property<bool>("Is_fiscalized");

                    b.Property<decimal>("Net_value");

                    b.Property<string>("Pay_methodsRefId")
                        .IsRequired();

                    b.Property<DateTime>("Print_date");

                    b.Property<decimal>("Tax_value");

                    b.HasKey("Sales_receiptId");

                    b.HasIndex("Pay_methodsRefId");

                    b.ToTable("Sales_ReceiptsDbSet");
                });

            modelBuilder.Entity("CNSS_ERP.DAL.Models.Sales.Tax_rates", b =>
                {
                    b.Property<string>("Tax_ratesId");

                    b.Property<DateTime>("Last_changed_date");

                    b.Property<int>("Number_value");

                    b.HasKey("Tax_ratesId");

                    b.ToTable("Tax_rates");
                });

            modelBuilder.Entity("CNSS_ERP.DAL.Models.Storage.Product_categories", b =>
                {
                    b.Property<int>("Product_categoriesId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<int>("Level");

                    b.Property<int?>("Master_product_categoryRefId")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Product_categoriesId");

                    b.HasIndex("Master_product_categoryRefId");

                    b.ToTable("Product_categoriesDbSet");
                });

            modelBuilder.Entity("CNSS_ERP.DAL.Models.Storage.Products", b =>
                {
                    b.Property<string>("ProductId");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("EAN_code")
                        .IsRequired();

                    b.Property<int>("Product_categoryRefId");

                    b.Property<string>("Tax_ratesRefId")
                        .IsRequired();

                    b.Property<string>("UnitsRefId")
                        .IsRequired();

                    b.HasKey("ProductId");

                    b.HasIndex("Product_categoryRefId");

                    b.HasIndex("Tax_ratesRefId");

                    b.HasIndex("UnitsRefId");

                    b.ToTable("ProductsDbSet");
                });

            modelBuilder.Entity("CNSS_ERP.DAL.Models.Storage.UnitConversions", b =>
                {
                    b.Property<int>("UnitConversionsId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Precision");

                    b.Property<string>("Units_1RefId")
                        .IsRequired();

                    b.Property<string>("Units_2RefId")
                        .IsRequired();

                    b.HasKey("UnitConversionsId");

                    b.HasIndex("Units_1RefId");

                    b.HasIndex("Units_2RefId");

                    b.ToTable("UnitConversionsDbSet");
                });

            modelBuilder.Entity("CNSS_ERP.DAL.Models.Storage.Units", b =>
                {
                    b.Property<string>("UnitId");

                    b.Property<string>("Description");

                    b.HasKey("UnitId");

                    b.ToTable("UnitsDbSet");
                });

            modelBuilder.Entity("CNSS_ERP.DAL.Models.UserAdditionalInfos", b =>
                {
                    b.Property<int>("UserAdditionalInfosId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("Position");

                    b.Property<string>("Street")
                        .IsRequired();

                    b.Property<string>("Surname")
                        .IsRequired();

                    b.HasKey("UserAdditionalInfosId");

                    b.ToTable("UserAdditionalInfosDbSet");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("CNSS_ERP.DAL.Models.ApplicationUser", b =>
                {
                    b.HasOne("CNSS_ERP.DAL.Models.UserAdditionalInfos", "userAdditionalInfos")
                        .WithMany()
                        .HasForeignKey("UserAdditionalInfosId");
                });

            modelBuilder.Entity("CNSS_ERP.DAL.Models.Purchase.Purchase_documents", b =>
                {
                    b.HasOne("CNSS_ERP.DAL.Models.Sales.Contractors", "Contractor")
                        .WithMany()
                        .HasForeignKey("ContractorsRefId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CNSS_ERP.DAL.Models.Sales.Pay_methodsinvoice", "Pay_method")
                        .WithMany()
                        .HasForeignKey("Pay_methodsRefId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CNSS_ERP.DAL.Models.Purchase.Purchase_positions", b =>
                {
                    b.HasOne("CNSS_ERP.DAL.Models.Storage.Products", "Product")
                        .WithMany()
                        .HasForeignKey("ProductsRefId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CNSS_ERP.DAL.Models.Purchase.Purchase_documents", "Purchase_document")
                        .WithMany()
                        .HasForeignKey("Purchase_documentsRefId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CNSS_ERP.DAL.Models.Sales.Tax_rates", "Tax_rate")
                        .WithMany()
                        .HasForeignKey("Tax_ratesRefId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CNSS_ERP.DAL.Models.Storage.Units", "Unit")
                        .WithMany()
                        .HasForeignKey("UnitsRefId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CNSS_ERP.DAL.Models.Sales.Receipt_positions", b =>
                {
                    b.HasOne("CNSS_ERP.DAL.Models.Storage.Products", "Product")
                        .WithMany()
                        .HasForeignKey("ProductsRefId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CNSS_ERP.DAL.Models.Sales.Sales_receipts", "Sales_receipt")
                        .WithMany()
                        .HasForeignKey("Sales_receiptsRefId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CNSS_ERP.DAL.Models.Sales.Tax_rates", "Tax_rate")
                        .WithMany()
                        .HasForeignKey("Tax_ratesRefId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CNSS_ERP.DAL.Models.Storage.Units", "Unit")
                        .WithMany()
                        .HasForeignKey("UnitsRefId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CNSS_ERP.DAL.Models.Sales.Sales_invoices", b =>
                {
                    b.HasOne("CNSS_ERP.DAL.Models.Sales.Contractors", "Contractor")
                        .WithMany()
                        .HasForeignKey("ContractorsRefId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CNSS_ERP.DAL.Models.Sales.Pay_methodsinvoice", "Pay_method")
                        .WithMany()
                        .HasForeignKey("Pay_methodsRefId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CNSS_ERP.DAL.Models.Sales.Sales_receipts", b =>
                {
                    b.HasOne("CNSS_ERP.DAL.Models.Sales.Pay_methodsreceipt", "Pay_method")
                        .WithMany()
                        .HasForeignKey("Pay_methodsRefId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CNSS_ERP.DAL.Models.Storage.Product_categories", b =>
                {
                    b.HasOne("CNSS_ERP.DAL.Models.Storage.Product_categories", "Master_product_category")
                        .WithMany()
                        .HasForeignKey("Master_product_categoryRefId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CNSS_ERP.DAL.Models.Storage.Products", b =>
                {
                    b.HasOne("CNSS_ERP.DAL.Models.Storage.Product_categories", "Product_category")
                        .WithMany()
                        .HasForeignKey("Product_categoryRefId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CNSS_ERP.DAL.Models.Sales.Tax_rates", "Tax_rate")
                        .WithMany()
                        .HasForeignKey("Tax_ratesRefId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CNSS_ERP.DAL.Models.Storage.Units", "Unit")
                        .WithMany()
                        .HasForeignKey("UnitsRefId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CNSS_ERP.DAL.Models.Storage.UnitConversions", b =>
                {
                    b.HasOne("CNSS_ERP.DAL.Models.Storage.Units", "Unit_1")
                        .WithMany()
                        .HasForeignKey("Units_1RefId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CNSS_ERP.DAL.Models.Storage.Units", "Unit_2")
                        .WithMany()
                        .HasForeignKey("Units_2RefId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("CNSS_ERP.DAL.Models.ApplicationUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("CNSS_ERP.DAL.Models.ApplicationUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CNSS_ERP.DAL.Models.ApplicationUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
