namespace OnlineStoreBackendAPI.Models;

public class Category : BaseModel
{
    public Category ParentCategory { get; set; }
}