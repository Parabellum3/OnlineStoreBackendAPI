namespace OnlineStoreBackendAPI.Models.ViewModels;

public class User : BaseModel
{
    public string Address { get; set; } = String.Empty;
    public string Email { get; set; } = String.Empty;
    public string PhoneNumber { get; set; } = String.Empty;
}