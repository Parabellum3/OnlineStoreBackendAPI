using OnlineStoreBackendAPI.DataAccess.Abstracts;
using OnlineStoreBackendAPI.Models.Enums;

namespace OnlineStoreBackendAPI.DataAccess.Repositories;

public class OrderRepository : BaseRepository<Order,int>, IOrderRepository
{
    public OrderRepository(IDataContext context) : base(context)
    {
    }
    

    public int Finalize(int orderId, ShippingMethod shippingMethod = ShippingMethod.NovaPoshta)
    {
        var order = GetById(orderId);
        order.ShippingMethod = shippingMethod;
        return _context.SaveChanges();
    }
    
}