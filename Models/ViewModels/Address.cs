namespace OnlineStoreBackendAPI.Models.ViewModels;

public class Address : BaseModel
{
    public string Country { get; set; }
    public string Street { get; set; }
    public string Building { get; set; }
    public string? Appartment { get; set; }
    
    public User User { get; set;  }
}