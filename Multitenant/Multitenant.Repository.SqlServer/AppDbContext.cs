using Finbuckle.MultiTenant.Stores;
using Microsoft.EntityFrameworkCore;

namespace Multitenant.Repository.SqlServer
{
    public class AppDbContext : EFCoreStoreDbContext
    { 
        public AppDbContext(DbContextOptions options) : base(options) { }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    string cnn = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=TenantDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        //    optionsBuilder.UseSqlServer(cnn);
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}