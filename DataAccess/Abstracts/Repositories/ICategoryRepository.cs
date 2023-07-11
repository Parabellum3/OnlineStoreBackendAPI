using OnlineStoreBackendAPI.Models.ViewModels;

namespace OnlineStoreBackendAPI.DataAccess.Abstracts;

public interface ICategoryRepository : IRepository<Category, int>
{
    public List<Product> GetProductsByCategory(int categoryId);
}