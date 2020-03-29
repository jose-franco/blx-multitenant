using Finbuckle.MultiTenant;
using Finbuckle.MultiTenant.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Multitenant.Models;

namespace Multitenant.Repository.SqlServer
{
    public class SampleContext : MultiTenantDbContext
    {
        public SampleContext(TenantInfo tenantInfo) : base(tenantInfo) { 
        
        }
        public SampleContext(TenantInfo tenantInfo, DbContextOptions<SampleContext> options) : base(tenantInfo, options) { 
        
        }
        
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasKey(e => e.CustomerId);
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}