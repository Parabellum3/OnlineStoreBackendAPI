namespace OnlineStoreBackendAPI.Models.ViewModels;

public class CartProduct
{
    public Cart Cart { get; set; }
    public Product Product { get; set; }
    public decimal Quantity { get; set; }
}