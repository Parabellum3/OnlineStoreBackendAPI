namespace OnlineStoreBackendAPI.Models.Entities;

public class CartProduct : BaseModel
{
    public Cart Cart { get;  set; }
    public Product Product { get;  set; }
    public int Quantity { get; set; }
    
    public double Total { get; set; }
}