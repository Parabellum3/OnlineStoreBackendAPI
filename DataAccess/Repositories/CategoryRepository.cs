using OnlineStoreBackendAPI.DataAccess.Abstracts;
using OnlineStoreBackendAPI.Models.DTO;
using OnlineStoreBackendAPI.Models.ViewModels;

namespace OnlineStoreBackendAPI.DataAccess.Repositories;

public class CategoryRepository : BaseRepository<Category,int>, ICategoryRepository
{
    public CategoryRepository(IDataContext context) : base(context){}

    public override Category GetById(int id)
    {
        return new Category
        {
            Id = id,
            Title = "TestCategory",
            Description = "TestDescription",
            ParentCategory = new Category
            {
                Id = 12345,
                Title = "TestParent"
            }
        };
    }

    public List<Product> GetProductsByCategory(int categoryId)
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
                    ParentCategory = new Category
                    {
                        Id = 12345,
                        Title = "TestParent"
                    }
                }
            }
        };
        return result;
    }

    public int Add(CategoryDto category)
    {
        return 200;
    }
}