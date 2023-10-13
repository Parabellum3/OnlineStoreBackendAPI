using System.Text.Json.Serialization;
using OnlineStoreBackendAPI.Models.Entities;

namespace OnlineStoreBackendAPI.DataAccess.Repositories;

public class CartProductDto
{
    [JsonConstructor]
    public CartProductDto(){}
    
    public CartProductDto(CartProduct cartProduct)
    {
        ProductName = cartProduct.Product.Title;
        Quantity = cartProduct.Quantity;
        Price = cartProduct.Product.Price;
        Total = Price * Quantity;
    }

    public string ProductName { get; private set; }

    public double Price { get; private set; }

    public int Quantity { get; private set; }

    public double Total { get; private set; } 
}