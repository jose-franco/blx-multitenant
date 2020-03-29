using Finbuckle.MultiTenant.Stores;
using Microsoft.EntityFrameworkCore;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class FinbuckleMultiTenantBuilderExtensions
    {
        public static FinbuckleMultiTenantBuilder WithEFCoreStore<TEFCoreStoreDbContext>(this FinbuckleMultiTenantBuilder builder, string conn)
            where TEFCoreStoreDbContext : EFCoreStoreDbContext
        {
            builder.Services.AddDbContext<TEFCoreStoreDbContext>(options=> options.UseSqlServer(conn));
            return builder.WithStore<EFCoreStore<TEFCoreStoreDbContext>>(ServiceLifetime.Scoped);
        }
    }
}