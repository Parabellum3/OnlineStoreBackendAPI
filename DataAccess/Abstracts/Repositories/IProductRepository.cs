using OnlineStoreBackendAPI.Models.ViewModels;

namespace OnlineStoreBackendAPI.DataAccess.Abstracts;

public interface IProductRepository : IRepository<Product, int>
{
    public List<Product> GetByCategory(int categoryId);
}