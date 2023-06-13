namespace OnlineStoreBackendAPI.Models;

public class Attribute : BaseModel
{
    public Category Category { get; set; } = new Category();
    
    
}