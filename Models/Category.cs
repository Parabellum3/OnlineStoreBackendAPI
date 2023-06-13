namespace OnlineStoreBackendAPI.Models;

public class Category : BaseModel
{
    public Category ParentCategory { get; set; } = new Category();

    public List<Attribute> Attributes { get; set; } = new List<Attribute>();
}