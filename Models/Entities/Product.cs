namespace OnlineStoreBackendAPI.Models.Entities;

public class Product : BaseModel
{
    public double Price { get; set; }
    public Category Category { get; set; }
    
    public ICollection<AttributeValue> AttributeValues { get; set; }
}