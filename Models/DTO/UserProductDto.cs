using System.Text.Json.Serialization;
using OnlineStoreBackendAPI.Models.DTO;
using OnlineStoreBackendAPI.Models.ViewModels;

namespace OnlineStoreBackendAPI.DataAccess.Repositories;

public class UserProductDto
{
    [JsonConstructor]
    public UserProductDto(){}
    
    public UserProductDto(OrderProduct orderProduct)
    {
        ProductName = orderProduct.Product.Title;
        Quantity = orderProduct.Quantity;
        Price = orderProduct.Product.Price;
        Total = Price * Quantity;
    }

    public string ProductName { get; private set; }

    public double Price { get; private set; }

    public int Quantity { get; private set; }

    public double Total { get; private set; } 
}