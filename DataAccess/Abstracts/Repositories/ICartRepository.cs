using System.IO.Compression;
using OnlineStoreBackendAPI.Models.DTO;
using OnlineStoreBackendAPI.Models.ViewModels;

namespace OnlineStoreBackendAPI.DataAccess.Abstracts;

public interface ICartRepository : IRepository<Cart,int>
{
    public List<ProductDto> GetProducts(int cartId);

    public int AddProductToCart(int productId, double quantity);

    public int RemoveProductFromCart(int productId, double quantity);

    public Order ConvertToOrder();
}
