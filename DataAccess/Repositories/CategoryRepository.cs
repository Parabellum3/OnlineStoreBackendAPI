using OnlineStoreBackendAPI.DataAccess.Abstracts;
using OnlineStoreBackendAPI.Models.DTO;
using OnlineStoreBackendAPI.Models.ViewModels;

namespace OnlineStoreBackendAPI.DataAccess.Repositories;

public class CategoryRepository : BaseRepository<Category,int>, ICategoryRepository
{
    private ICategoryRepository _categoryRepositoryImplementation;
    public CategoryRepository(IDataContext context) : base(context){}


    public  List<Product> GetProductsByCategory(int categoryId)
    {
        return  _context.Products.Where(p => p.Category.Id == categoryId).ToList();
    }

    public int Add(CategoryDto dto)
    {
        _context.Categories.Add(new Category
        {
            Id = dto.Id,
            Title = dto.Title,
            Description = dto.Description,
            ParentCategory = _context.Categories.Find(dto.ParentCategory.Id)
        });
        return _context.SaveChanges();
    }

    public int AddAttribute(ProductAttribute attribute)
    {
        _context.ProductAttributes.Add(attribute);
        return _context.SaveChanges();
    }
}