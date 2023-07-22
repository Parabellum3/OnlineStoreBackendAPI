using OnlineStoreBackendAPI.Models.Enums;

namespace OnlineStoreBackendAPI.DataAccess.Abstracts;
public interface IOrderRepository : IRepository<Order, int>
{
    int Finalize(int orderId, ShippingMethod shippingMethod);
}