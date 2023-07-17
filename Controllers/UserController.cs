using Microsoft.AspNetCore.Mvc;
using OnlineStoreBackendAPI.DataAccess.Abstracts;
using OnlineStoreBackendAPI.Models.DTO;
using OnlineStoreBackendAPI.Models.ViewModels;

namespace OnlineStoreBackendAPI.Controllers{

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _repository;

        public UserController(IUserRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public int AddProductToUserCart(int productId)
        {
            return _repository.AddProductToCart(productId);
        }

        [HttpPost]
        public bool CreateOrder()
        {
            return _repository.CreateOrder();
        }

        [HttpGet]
        public List<ProductDto> GetProducts()
        {
            return _repository.GetProducts();
        }
    }
}