namespace OnlineStoreBackendAPI.Models.ViewModels;

public class Attribute : BaseModel
{
    public Category Category { get; set; } = new Category();
}