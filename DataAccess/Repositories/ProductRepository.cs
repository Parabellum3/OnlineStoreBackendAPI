using OnlineStoreBackendAPI.DataAccess.Abstracts;
using OnlineStoreBackendAPI.Models.ViewModels;

namespace OnlineStoreBackendAPI.DataAccess.Repositories;

public class ProductRepository : BaseRepository<Product, int>, IProductRepository
{
    public ProductRepository(IDataContext context) : base(context)
    {
    }

    public override Product GetById(int id)
    {
        return new Product
        {
            Id = id,
            Title = "Test",
            Description = "Test",
            Price = 12345,
            Category = new Category
            {
                Id = 123,
                Title = "TestCategory",
                Description = "TestDescription",
                ParentCategory = null
            },
            AttributeValues = new List<AttributeValue>()

        };
    }

    public List<Product> GetByCategory(int categoryId)
    {
        var result = new List<Product>
        {
            new Product
            {
                Id = 123,
                Title = "Test",
                Description = "Test",
                Price = 12345,
                Category = new Category
                {
                    Id = categoryId,
                    Title = "TestCategory",
                    Description = "TestDescription",
                    ParentCategory = null
                }
            }
        };
        return result;
    }

    public int Add(Product product)
    {
        return 200;
    }

}