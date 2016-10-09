//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Infrastructure;

//namespace CNSS_ERP.DAL
//{
//    public class TemporaryDbContextFactory : IDbContextFactory<ApplicationDbContext>
//    {
//        public ApplicationDbContext Create(DbContextFactoryOptions options)
//        {
//            var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
//            builder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Łukasz\\Desktop\\NCSERP\\CNS-ERP\\src\\CNSS-ERP.DAL\\Data\\CNS-Database.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
//            return new ApplicationDbContext(builder.Options);
//        }
//    }


//}
