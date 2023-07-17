using OnlineStoreBackendAPI.Models.ViewModels;

namespace OnlineStoreBackendAPI.DataAccess.Abstracts;

public class Order
{
    public double Total { get; private set; }

    public List<Product> Products { get; private set; }

    public User User { get; private set; }
}