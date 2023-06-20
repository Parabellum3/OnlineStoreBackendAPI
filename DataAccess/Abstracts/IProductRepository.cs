using OnlineStoreBackendAPI.Models.ViewModels;

namespace OnlineStoreBackendAPI.DataAccess.Abstracts;

public interface IProductRepository : IRepository<Product, int>
{
    public IEnumerable<Product> GetByCategory(int categoryId);
}