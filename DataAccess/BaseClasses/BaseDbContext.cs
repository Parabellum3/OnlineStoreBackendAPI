using Microsoft.EntityFrameworkCore;
using OnlineStoreBackendAPI.Models.Entities;


namespace OnlineStoreBackendAPI.DataAccess.Abstracts;

public abstract class BaseDbContext<T>: DbContext,IDataContext where T: DbContext
{
    #region Constructors: Public

    public BaseDbContext(DbContextOptions<T> options) : base(options) { }

    #endregion
    #region Properties: Public

    public DbSet<Product> Products { get; set; }
    public DbSet<ProductAttribute> ProductAttributes { get; set; }
    public DbSet<AttributeValue> AttributeValues { get; set; }
    public DbSet<OrderProduct> UserProducts { get; set; }
    public DbSet<OrderProduct> OrderProducts { get; set; }
    public DbSet<CartProduct> CartProducts { get; set; }
    public DbSet<Cart> Carts { get; set; }
    public DbSet<Order> Orders { get; set; }

    public DbSet<Category> Categories { get; set; }
    public DbSet<User> Users { get; set; }

    #endregion

    #region Methods : public

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
     //   modelBuilder.Entity<Product>().Navigation("Category").AutoInclude();
        base.OnModelCreating(modelBuilder);
    }

    #endregion
}