using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;
using OnlineStoreBackendAPI.Models;
using OnlineStoreBackendAPI.Models.ViewModels;
using Attribute = System.Attribute;

namespace OnlineStoreBackendAPI.DataAccess.Abstracts;

public abstract class BaseDbContext<T>: DbContext,IDataContext where T: DbContext
{
    #region Constructors: Public

    public  BaseDbContext(DbContextOptions<T> options): base(options) {
    }

    #endregion
    #region Properties: Public

    public DbSet<Product> Products { get; set; }
    public DbSet<Attribute> Attributes { get; set; }
    public DbSet<AttributeValue> AttributeValues { get; set; }
    public DbSet<Cart> Carts { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<CartProduct> CartProducts { get; set; }
    public DbSet<User> Users { get; set; }
    
    #endregion


}