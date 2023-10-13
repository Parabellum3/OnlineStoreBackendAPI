using OnlineStoreBackendAPI.Models.Entities;
using OnlineStoreBackendAPI.Models.Enums;

namespace OnlineStoreBackendAPI.DataAccess.Abstracts;
public interface IOrderRepository : IRepository<Order, int>
{
    int Finalize(int orderId, ShippingMethod shippingMethod);

    Cart GetByUser(int userId);

    int CreateOrderFromCart(int cartId);
}