using OnlineStoreBackendAPI.DataAccess.Abstracts;
using OnlineStoreBackendAPI.Models.Entities;
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
        return Context.SaveChanges();
    }

    public Cart GetByUser(int userId)
    {
       return Context.Carts.FirstOrDefault(cart => cart.User.Id == userId);
    }

    public int CreateOrderFromCart(int cartId)
    {
        var cart = Context.Carts.Find(cartId);
        if (cart == null)
        {
            throw new ArgumentException();
        }
        
        var order = new Order
        {
            
            Total = cart.Total,
            User = cart.User,
            ShippingMethod = ShippingMethod.NovaPoshta,
            ShippingAddress = cart.User?.Address,
        };
        var orderProducts = new List<OrderProduct>();
        foreach (var cartProduct in cart.CartProducts)
        {
            orderProducts.Add(new OrderProduct
            {
                Product = cartProduct.Product,
                Quantity = cartProduct.Quantity,
                Total = cartProduct.Total,
                Order = order
            });
        }
        order.OrderProducts = orderProducts;
        
        Context.Orders.Add(order);
        return Context.SaveChanges();
    }
}