using Microsoft.EntityFrameworkCore;
using OnlineStoreBackendAPI.DataAccess.Abstracts;
using OnlineStoreBackendAPI.Models.Entities;

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
        Context.Carts.Add(cart);
        Context.SaveChanges();
        return cart.Id;
    }

    public int AddProductToCart(int productId, int cartId, int quantity)
    {
        var cart = Context.Carts.Find(cartId);
        if (cart == null)
        {
            cart = new Cart
            {
                Title = $"Cart {cartId}",
                Description = "",
                Total = 0,
                CartProducts = null,
                User = null
            };
        }
        var cartProduct = new CartProduct
        {
            Product = Context.Products.Find(productId),
            Cart = cart,
            Quantity = quantity
        };
        cartProduct.Total = cartProduct.Product.Price * cartProduct.Quantity;
        Context.CartProducts.Add(cartProduct);
        cart.Total += cartProduct.Total;
        return Context.SaveChanges();

    }

    public int AddProductsToCart(Dictionary<int, int> productRange, int cartId)
    {
        var cart = Context.Carts.Find(cartId);
        foreach (var product in productRange)
        {
            var cartProduct = new CartProduct
            {
                Product = Context.Products.Find(product.Key),
                Cart = cart,
                Quantity = product.Value
            };
            Context.CartProducts.Add(cartProduct);
        }
        return Context.SaveChanges();
    }

    public int CreateOrder(int cartId)
    {
        var cart = Context.Carts.Find(cartId);
        var order = new Order()
        {
            ShippingAddress = cart.User.Address,
            User = cart.User,
            Total = cart.Total
        };
        Context.Orders.Add(order);
        return Context.SaveChanges();
    }

    public List<CartProductDto> GetProducts(int cartId)
    {
       var cart = Context.Carts.Include(c => c.CartProducts).FirstOrDefault(p => p.Id == cartId);
       if (cart == null)
       {
           throw new ArgumentException("Cart with such Id doesn't exist");
       }
       var result = new List<CartProductDto>();
       foreach (var cartProduct in cart.CartProducts)
       {
           result.Add(new CartProductDto(cartProduct));
       }

       return result;
    }

    public int RemoveProduct(int productId, int cartId)
    {
        var products= Context.CartProducts.Where(cartProduct => cartProduct.Product.Id == productId && cartProduct.Cart.Id == cartId).ToList();
        Context.CartProducts.RemoveRange(products);
        return Context.SaveChanges();
    }
}


