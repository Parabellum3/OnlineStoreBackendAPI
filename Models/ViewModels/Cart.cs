namespace OnlineStoreBackendAPI.Models.ViewModels;
public class Cart : BaseModel
{
    public double Total { get; set; }
    
    public ICollection<CartProduct> CartProducts { get; set; }

    public User User { get; set; }
}