using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CNSS_ERP.DAL.Models;
using CNSS_ERP.DAL.Models.Sales;
using CNSS_ERP.DAL.Models.Storage;
using CNSS_ERP.DAL.Models.Purchase;
using CNS_ERP.Models;

namespace CNSS_ERP.DAL
{
    public class ApplicationDbContext :IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            
            base.OnModelCreating(builder);
            builder.Entity<ApplicationUser>();
            builder.Entity<Storages>();
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        #region DbSet's
        public DbSet<UserAdditionalInfos> UserAdditionalInfosDbSet { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Pay_methodsinvoice> Pay_methodsinvoiceDbSet { get; set; }
        public DbSet<Pay_methodsreceipt> Pay_methodsreceiptDbSet { get; set; }
        public DbSet<Receipt_positions> Receipt_positionsDbSet { get; set; }
        public DbSet<Sales_invoices> Sales_invoicesDbSet { get; set; }
        public DbSet<Sales_receipts> Sales_ReceiptsDbSet { get; set; }
        public DbSet<Products> ProductsDbSet { get; set; }
        public DbSet<Units> UnitsDbSet { get; set; }
        public DbSet<UnitConversions> UnitConversionsDbSet { get; set; }
        public DbSet<Purchase_documents> Purchase_documentsDbSet { get; set; }
        public DbSet<Purchase_positions> Purchase_positionsDbSet { get; set; }

        public DbSet<Product_categories> Product_categoriesDbSet { get; set; }
        
        public DbSet<Tax_rates> Tax_ratesDbSet { get; set; }
        
        public DbSet<Movie> MovieDbSet { get; set; }
        public DbSet<Storages> StoragesDbSet { get; set; }

        #endregion
        //   public DbSet<ApplicationRole> IdentityRole { get; set; }
    }
}
