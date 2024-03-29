using OnlineStoreBackendAPI.Models.DTO;
using OnlineStoreBackendAPI.Models.Entities;

namespace OnlineStoreBackendAPI.DataAccess.Abstracts;

public interface ICategoryRepository : IRepository<Category, int>
{
    public List<Product> GetProductsByCategory(int categoryId);

    public int Add(CategoryDto dto);
    public int AddAttribute(ProductAttributeDto attribute);
}