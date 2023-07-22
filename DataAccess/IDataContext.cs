using Microsoft.EntityFrameworkCore;
using OnlineStoreBackendAPI.Models.ViewModels;


namespace OnlineStoreBackendAPI.DataAccess.Abstracts;

public interface IDataContext
{
    DbSet<Product> Products { get; set; }
    DbSet<ProductAttribute> ProductAttributes { get; set; }
    DbSet<AttributeValue> AttributeValues { get; set; }
    DbSet<Category> Categories { get; set; }
    DbSet<User> Users { get; set; }
    DbSet<OrderProduct> UserProducts { get; set; }
    DbSet<TEntity> Set<TEntity>() where TEntity : class;
    DbSet<OrderProduct> OrderProducts { get; set; }
    DbSet<CartProduct> CartProducts { get; set; }
    
    DbSet<Cart> Carts { get; set; }
    DbSet<Order> Orders { get; set;}
    int SaveChanges();
}