using Microsoft.AspNetCore.Mvc;
using OnlineStoreBackendAPI.DataAccess.Abstracts;
using OnlineStoreBackendAPI.Models.DTO;
using OnlineStoreBackendAPI.Models.ViewModels;

namespace OnlineStoreBackendAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _repository;

        public ProductController(IProductRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("{id}")]
        public  ProductDto GetById(int id)
        {
            var product =  _repository.GetById(id);
            return new ProductDto( product);
        }

        [HttpGet("{categoryId}")]
        public ActionResult GetByCategory(int categoryId)
        {
            var products = _repository.GetByCategory(categoryId);
            List<ProductDto> output = new List<ProductDto>();
            foreach (Product product in products)
            {
                output.Add(new ProductDto(product));
            }

            if (output.Count == 0)
            {
                return NotFound("No products in this category");
            }
            return (Ok(output));
        }

        [HttpPost]
        public int Add(ProductDto dto)
        {
            
            return 200;
        }

    }
}
