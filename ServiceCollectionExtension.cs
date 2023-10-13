using OnlineStoreBackendAPI.DataAccess;
using OnlineStoreBackendAPI.DataAccess.Abstracts;
using OnlineStoreBackendAPI.DataAccess.Repositories;

namespace OnlineStoreBackendAPI.Extensions;

public static class ServiceCollectionExtension
{
    public static void BindServices(this IServiceCollection collection)
    {
        collection.AddScoped<IProductRepository, ProductRepository>();
        collection.AddScoped<IDataContext, MsSqlDataContext>();
        collection.AddScoped<ICategoryRepository, CategoryRepository>();
        collection.AddScoped<ICartRepository, CartRepository>();
        collection.AddScoped<IOrderRepository, OrderRepository>();
    }
}