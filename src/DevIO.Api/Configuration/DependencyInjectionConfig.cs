using DevIO.Business.Interfaces.Repositories;
using DevIO.Data.Context;
using DevIO.Data.Repositories;

namespace DevIOApi.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<MyDbContext>();
            services.AddScoped<IProviderRepository, ProviderRepository>();
            //services.AddScoped<IAddressRepository, AddressRepository>();
            //services.AddScoped<IProductRepository, ProductRepository>();

            return services;
        }
    }
}
