using OnlineStoreBackendAPI.Models.DTO;
using OnlineStoreBackendAPI.Models.ViewModels;

namespace OnlineStoreBackendAPI.DataAccess.Abstracts;

public interface IUserRepository : IRepository<User, int>
{
    public int AddProductToCart(int productId);

    public bool CreateOrder();
    List<ProductDto> GetProducts();
}