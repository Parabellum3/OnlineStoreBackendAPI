using Microsoft.EntityFrameworkCore;
using OnlineStoreBackendAPI.Models.ViewModels;
using Attribute = System.Attribute;

namespace OnlineStoreBackendAPI.DataAccess.Abstracts;

public interface IDataContext 
{
    DbSet<Product> Products { get; set; }
    DbSet<Attribute> Attributes { get; set; }
    DbSet<AttributeValue> AttributeValues { get; set; }
    DbSet<Cart> Carts { get; set; }
    DbSet<Category> Categories { get; set; }
    DbSet<CartProduct> CartProducts { get; set; }
    DbSet<User> Users { get; set; }

    public DbSet<TEntity> Set<TEntity>() where TEntity : class;

    int SaveChanges();
}