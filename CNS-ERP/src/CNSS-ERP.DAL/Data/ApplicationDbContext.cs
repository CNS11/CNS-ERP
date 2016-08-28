using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CNSS_ERP.DAL.Models;
using CNSS_ERP.DAL.Models.Sales;

namespace CNSS_ERP.DAL
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            
            base.OnModelCreating(builder);
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
        public DbSet<Sales_Receipts> Sales_ReceiptsDbSet { get; set; }
        public DbSet<Tax_rates> Tax_ratesDbSet { get; set; }

        #endregion
        //   public DbSet<ApplicationRole> IdentityRole { get; set; }
    }
}
