using OnlineStoreBackendAPI.Models.Enums;
using OnlineStoreBackendAPI.Models.Entities;

namespace OnlineStoreBackendAPI.DataAccess.Abstracts;

public class Order : BaseModel
{
    public double Total { get;  set; }

    public User User { get;  set; }
    
    public ICollection<OrderProduct> OrderProducts { get; set; }

    public ShippingMethod ShippingMethod { get; set; }
    
    public Address? ShippingAddress { get; set; }
    
    public OrderStatus? Status { get; set; }
}
