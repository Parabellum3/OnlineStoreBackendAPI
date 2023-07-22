using OnlineStoreBackendAPI.DataAccess.Abstracts;

namespace OnlineStoreBackendAPI.Models.ViewModels;

public class OrderProduct : BaseModel
{
    public Order Order { get; private set; }
    public Product Product { get; private set; }
    public int Quantity { get; set; }

    public double Total { get; set; }
}