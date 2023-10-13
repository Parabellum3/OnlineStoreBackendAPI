using Microsoft.AspNetCore.Mvc;
using OnlineStoreBackendAPI.DataAccess.Abstracts;

namespace OnlineStoreBackendAPI.Controllers{

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartRepository _repository;

        public CartController(ICartRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public ActionResult AddProductToUserCart(int productId, int cartId, int quantity = 1 )
        {
            return Ok(_repository.AddProductToCart(productId, cartId, quantity));
        }

        [HttpPost]
        public ActionResult CreateOrder(int cartId)
        {
            return Ok( _repository.CreateOrder(cartId));
        }

        [HttpGet]
        public  ActionResult GetProducts(int cartId)
        {
            return  Ok(_repository.GetProducts(cartId));
        }

        [HttpPost]
        public ActionResult RemoveProduct(int productId, int cartId)
        {
            return Ok(_repository.RemoveProduct(productId, cartId));
        }
    }
}