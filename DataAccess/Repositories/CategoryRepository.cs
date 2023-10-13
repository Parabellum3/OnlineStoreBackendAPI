using Microsoft.EntityFrameworkCore;
using OnlineStoreBackendAPI.DataAccess.Abstracts;
using OnlineStoreBackendAPI.Models.DTO;
using OnlineStoreBackendAPI.Models.Entities;

namespace OnlineStoreBackendAPI.DataAccess.Repositories;

public class CategoryRepository : BaseRepository<Category,int>, ICategoryRepository
{
    private ICategoryRepository _categoryRepositoryImplementation;
    public CategoryRepository(IDataContext context) : base(context){}


    public  List<Product> GetProductsByCategory(int categoryId)
    {
        return  Context.Products.Where(p => p.Category.Id == categoryId).ToList();
    }

    public int Add(CategoryDto dto)
    {
        Context.Categories.Add(new Category
        {
            Id = dto.Id,
            Title = dto.Title,
            Description = dto.Description,
            ParentCategory = Context.Categories.Find(dto.ParentCategory.Id)
        });
        return Context.SaveChanges();
    }

    public int AddAttribute(ProductAttributeDto attribute)
    {
        var category = Context.Categories.Include(c => c.Products).FirstOrDefault(p => p.Id == attribute.CategoryId);
        var productAttribute = new ProductAttribute()
        {
            Title = attribute.Title,
            Category = category
        };
        Context.ProductAttributes.Add(productAttribute);
        
        foreach (Product product in category.Products)
        {
            Context.AttributeValues.Add(new AttributeValue()
            {
                TextValue = attribute.DefValue,
                Product = product,
                ProductAttribute = productAttribute
            });
        }
        return Context.SaveChanges();
    }
}