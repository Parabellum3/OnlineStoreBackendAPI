using OnlineStoreBackendAPI.Models.DTO;
using OnlineStoreBackendAPI.Models.Entities;

namespace OnlineStoreBackendAPI.DataAccess.Abstracts;

public interface IProductRepository : IRepository<Product, int>
{
    public List<Product> GetByCategory(int categoryId);

    int Add(ProductDto dto);
}