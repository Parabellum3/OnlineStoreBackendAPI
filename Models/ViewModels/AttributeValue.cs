namespace OnlineStoreBackendAPI.Models.ViewModels;

public class AttributeValue : BaseModel
{
    public Product Product { get; set; } = new Product();
    public Attribute Attribute { get; set; } = new Attribute();
    public int IntValue { get; set; } = default(int);
    public string TextValue { get; set; } = String.Empty;
    public bool BoolValue { get; set; } = false;
    public DateTime DateTimeValue { get; set; } = DateTime.MinValue;
    public Guid GuidValue { get; set; } = Guid.Empty;

}