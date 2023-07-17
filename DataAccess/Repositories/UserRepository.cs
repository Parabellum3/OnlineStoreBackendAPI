using OnlineStoreBackendAPI.DataAccess.Abstracts;
using OnlineStoreBackendAPI.Models.DTO;
using OnlineStoreBackendAPI.Models.ViewModels;

namespace OnlineStoreBackendAPI.DataAccess.Repositories;

public class UserRepository : IUserRepository
{
    public IEnumerable<User> GetCollection(int fetch = 30, int skip = 0)
    {
        throw new NotImplementedException();
    }

    public User GetById(int id)
    {
        throw new NotImplementedException();
    }

    public int Insert(User entity)
    {
        throw new NotImplementedException();
    }

    public int Delete(int id)
    {
        throw new NotImplementedException();
    }

    public int Delete(User entity)
    {
        throw new NotImplementedException();
    }

    public int Update(User entity)
    {
        throw new NotImplementedException();
    }

    public int AddProductToCart(int productId)
    {
        throw new NotImplementedException();
    }

    public bool CreateOrder()
    {
        throw new NotImplementedException();
    }

    public List<ProductDto> GetProducts()
    {
        throw new NotImplementedException();
    }
}