using Microsoft.Extensions.DependencyInjection;
using WarehouseManagent.Repository.Implementation;
using WarehouseManagent.Repository.Interfaces;

namespace WarehouseManagent.Repository
{
    public static class ConfigureInjections
    {
        public static ServiceProvider ServiceProvider { get; private set; }
        public static void Config()
        {
            ServiceProvider = new ServiceCollection()
            .AddTransient<ISupplierRepository, SupplierRepository>()
            .AddTransient<ICategoryRepository, CategoryRepository>()
            .AddTransient<IProductRepository, ProductRepository>() 
            .BuildServiceProvider();
        }
    }
}
