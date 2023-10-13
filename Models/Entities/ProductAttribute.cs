namespace OnlineStoreBackendAPI.Models.Entities;

public class ProductAttribute : BaseModel
{
    public Category Category { get; set; }
    
    public string DataType { get; set; }
}