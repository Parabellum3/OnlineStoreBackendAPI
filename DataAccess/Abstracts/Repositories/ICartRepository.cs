using OnlineStoreBackendAPI.DataAccess.Repositories;
using OnlineStoreBackendAPI.Models.Entities;

namespace OnlineStoreBackendAPI.DataAccess.Abstracts;

public interface ICartRepository : IRepository<Cart, int>
{
    public int CreateCart(User user);
    int AddProductToCart(int productId, int cartId, int quantity = 1);
    int CreateOrder(int userId);
    List<CartProductDto> GetProducts(int userId);
    int RemoveProduct(int productId, int cartId);
}