using Finbuckle.MultiTenant.Stores;
using Multitenant.Repository;
using Multitenant.Repository.SqlServer;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class IServiceCollectionExtensions
    {
        public static void AddMultitenantConfiguration(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<SampleContext>();
            services.AddMultiTenant()
                    .WithEFCoreStore<EFCoreStoreDbContext>(connectionString)
                    .WithRouteStrategy();
        }

        public static void AddServicesConfiguration(this IServiceCollection services)
        {
            services.AddScoped<ICustomerRepository, CustomerRepository>();
        }
    }
}