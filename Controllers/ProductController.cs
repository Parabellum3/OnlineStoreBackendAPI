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

        [HttpPost]
        public ProductDto GetById([FromBody]int id)
        {
            return  new ProductDto(_repository.GetById(id));
        }

        [HttpPost]
        public List<ProductDto> GetByCategory(int categoryId)
        {
          var products  = _repository.GetByCategory(categoryId);
          List<ProductDto> output = new List<ProductDto>();
          foreach (Product product in products)
          {
              output.Add(new ProductDto(product));
          }

          return output;
        }
        
       
    }
}
