using OnlineStoreBackendAPI.DataAccess.Abstracts;

namespace OnlineStoreBackendAPI.Models.Entities;

public class OrderProduct : BaseModel
{
    public Order Order { get; set; }
    public Product Product { get; set; }
    public int Quantity { get; set; }

    public double Total { get; set; }
}