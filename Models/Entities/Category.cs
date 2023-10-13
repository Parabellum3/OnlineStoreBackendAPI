namespace OnlineStoreBackendAPI.Models.Entities;

public class Category : BaseModel
{
    
    public Category? ParentCategory { get; set; }
    public ICollection<ProductAttribute> ProductAttributes { get; set; }
    public ICollection<Product> Products { get; set; }
    public ICollection<Category> ChildCategories { get; set; }
}

