using OnlineStoreBackendAPI.DataAccess.Abstracts;
using OnlineStoreBackendAPI.Models.DTO;
using OnlineStoreBackendAPI.Models.Entities;

namespace OnlineStoreBackendAPI.DataAccess.Repositories;

public class ProductRepository : BaseRepository<Product, int>, IProductRepository
{
    #region Methods : private

    private List<AttributeValue> ParseAttributeValues(ProductDto dto)
    {
        var result = new List<AttributeValue>();
        foreach (KeyValuePair<string,string> dtoAttribute in dto.Attributes)
        {
            result.Add(new AttributeValue()
            {
                ProductAttribute = Context.ProductAttributes.FirstOrDefault(p => p.Title == dtoAttribute.Key),
                TextValue = dtoAttribute.Value
            });
        }
        return result;
    }

    #endregion

    #region Constructors : Public
    public ProductRepository(IDataContext context) : base(context) {}
    
    #endregion

    #region Methods : public
    public  List<Product> GetByCategory(int categoryId)
    {
        return  Context.Products.Where(p => p.Category.Id == categoryId).ToList();
    }

    public int Add(ProductDto dto)
    {
        
        return Insert( new Product
        {
            Id = dto.Id,
            Title = dto.Title,
            Description = dto.Description,
            Price = dto.Price,
            Category = Context.Categories.FirstOrDefault(c => c.Title == dto.Category),
            AttributeValues = ParseAttributeValues(dto)
        });
    }

    #endregion
    
    
}