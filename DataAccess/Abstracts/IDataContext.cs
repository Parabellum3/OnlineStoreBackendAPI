using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;
using OnlineStoreBackendAPI.Models.ViewModels;
using Attribute = System.Attribute;

namespace OnlineStoreBackendAPI.DataAccess.Abstracts;

public interface IDataContext 
{
    DbSet<Product> Products { get; set; }
    DbSet<Attribute> Attributes { get; set; }
    DbSet<AttributeValue> AttributeValues { get; set; }
    DbSet<Category> Categories { get; set; }
    DbSet<User> Users { get; set; }

    DbSet<UserProduct> UserProducts { get; set; }

    public DbSet<TEntity> Set<TEntity>() where TEntity : class;

    int SaveChanges();
}