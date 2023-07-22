namespace OnlineStoreBackendAPI.Models.ViewModels;

public class AttributeValue : BaseModel
{
    public Product Product { get; set; }
    public ProductAttribute ProductAttribute { get; set; }
    public int IntValue { get; set; }
    public string? TextValue { get; set; }
    public bool? BoolValue { get; set; }
    public DateTime DateTimeValue { get; set; }
    public Guid? GuidValue { get; set; }
}