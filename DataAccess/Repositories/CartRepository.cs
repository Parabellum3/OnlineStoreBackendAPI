using Microsoft.EntityFrameworkCore;
using OnlineStoreBackendAPI.DataAccess.Abstracts;
using OnlineStoreBackendAPI.Models.ViewModels;

namespace OnlineStoreBackendAPI.DataAccess.Repositories;

public class CartRepository : BaseRepository<Cart,int>, ICartRepository
{
    public CartRepository(IDataContext context) : base(context)
    {
    }

    public int CreateCart(User user)
    {
        var cart = new Cart()
        {
            User = user
        };
        _context.Carts.Add(cart);
        _context.SaveChanges();
        return cart.Id;
    }

    public int AddProductToCart(int productId, int cartId, int quantity)
    {
        var cart = _context.Carts.Find(cartId);
        var cartProduct = new CartProduct
        {
            Product = _context.Products.Find(productId),
            Cart = cart,
            Quantity = quantity
        };
        cartProduct.Total = cartProduct.Product.Price * cartProduct.Quantity;
        _context.CartProducts.Add(cartProduct);
        cart.Total += cartProduct.Total;
        return _context.SaveChanges();

    }

    public int AddProductsToCart(Dictionary<int, int> productRange, int cartId)
    {
        var cart = _context.Carts.Find(cartId);
        foreach (var product in productRange)
        {
            var cartProduct = new CartProduct
            {
                Product = _context.Products.Find(product.Key),
                Cart = cart,
                Quantity = product.Value
            };
            _context.CartProducts.Add(cartProduct);
        }
        return _context.SaveChanges();
    }

    public int CreateOrder(int cartId)
    {
        var cart = _context.Carts.Find(cartId);
        var order = new Order()
        {
            ShippingAddress = cart.User.Address,
            User = cart.User,
            Total = cart.Total
        };
        _context.Orders.Add(order);
        return _context.SaveChanges();
    }

    public List<CartProductDto> GetProducts(int cartId)
    {
       var cart = _context.Carts.Include(c => c.CartProducts).FirstOrDefault(p => p.Id == cartId);
       var result = new List<CartProductDto>();
       foreach (var cartProduct in cart.CartProducts)
       {
           result.Add(new CartProductDto(cartProduct));
       }

       return result;
    }
}


