using Microsoft.CodeAnalysis.Operations;

namespace OnlineStoreBackendAPI.Models;

public class ProductInCart
{
    public Cart Cart { get; set; }
    public BaseProduct Product { get; set; }
    public decimal Quantity { get; set; }
}