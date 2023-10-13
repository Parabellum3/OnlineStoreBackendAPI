namespace OnlineStoreBackendAPI.Models.Entities;
public class Cart : BaseModel
{
    public double Total { get; set; }
    
    public ICollection<CartProduct> CartProducts { get; set; }

    public User? User { get; set; } 
}