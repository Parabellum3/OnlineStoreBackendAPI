using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
using OnlineStoreBackendAPI.Models;

namespace OnlineStoreBackendAPI.DataAccess;

public class StoreDbContext : DbContext
{
    public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options) { }
    
    private Dictionary<int, BaseProduct> MockProductList { get; set; }

    public BaseProduct GetProductById(int productId)
    {
        MockProductList.Add(productId, new BaseProduct
        {
            Id = productId,
            Name = "MockProduct",
            Description = "MockProduct",
            Price = 1,
            Quantity = 1,
            Category = new Category()
        });
        return MockProductList[productId];
    }
}