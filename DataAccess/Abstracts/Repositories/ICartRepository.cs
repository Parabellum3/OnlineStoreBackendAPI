using Microsoft.AspNetCore.Mvc;
using OnlineStoreBackendAPI.DataAccess.Repositories;
using OnlineStoreBackendAPI.Models.DTO;
using OnlineStoreBackendAPI.Models.ViewModels;

namespace OnlineStoreBackendAPI.DataAccess.Abstracts;

public interface ICartRepository : IRepository<Cart, int>
{
    public int CreateCart(User user);
    int AddProductToCart(int productId, int cartId, int quantity = 1);
    int CreateOrder(int userId);
    List<UserProductDto> GetProducts(int userId);
}