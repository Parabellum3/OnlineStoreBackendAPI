using OnlineStoreBackendAPI.DataAccess.Abstracts;
using OnlineStoreBackendAPI.Models.ViewModels;

namespace OnlineStoreBackendAPI.DataAccess.Repositories;

public class ProductRepository : BaseRepository<Product, int>, IProductRepository
{
    public ProductRepository(IDataContext context) : base(context) {}

    public override Product GetById(int id)
    {
        return new Product
        {
            Id = id,
            Name = "Test",
            Description = "Test",
            Price = 12345, 
            Category = new Category
            {
                Id = 123,
                Name = "TestCategory",
                Description = "TestDescription",
                ParentCategory = null
            },
            AttributeValues = new List<AttributeValue>()
            
        };
    }
    
    public IEnumerable<Product> GetByCategory(int categoryId)
    {
        var result = new List<Product>();
        result.Add(new Product
        {
            Id = 123,
            Name = "Test",
            Description = "Test",
            Price = 12345, 
            Category = new Category
            {
                Id = categoryId,
                Name = "TestCategory",
                Description = "TestDescription",
                ParentCategory = null
            }
        }
        );
        return result;
    }
}