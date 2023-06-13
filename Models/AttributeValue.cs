namespace OnlineStoreBackendAPI.Models;

public class AttributeInProduct : BaseModel
{
    public BaseProduct Product { get; set; } = new BaseProduct(); 

    public Attribute Attribute { get; set; } = new Attribute();

    public int IntValue { get; set; } = default(int);

    public string TextValue { get; set; } = String.Empty;

    public bool BoolValue { get; set; } = false;
    
    public DateTime DateTimeValue { get; set; } = DateTime.MinValue;

    public Guid GuidValue { get; set; }

}