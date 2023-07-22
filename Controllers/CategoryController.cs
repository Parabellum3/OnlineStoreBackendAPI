using Microsoft.AspNetCore.Mvc;
using OnlineStoreBackendAPI.DataAccess.Abstracts;
using OnlineStoreBackendAPI.Models.DTO;
using OnlineStoreBackendAPI.Models.ViewModels;

namespace OnlineStoreBackendAPI.Controllers;

public class CategoryController : ControllerBase
{

    private readonly ICategoryRepository _repository;

    public CategoryController(ICategoryRepository repository)
    {
        _repository = repository;
    }

    [Route("api/[controller]/[action]")]
    [HttpGet]
    public  CategoryDto GetById(int id)
    {
        return new CategoryDto(_repository.GetById(id));
    }

    [Route("api/[controller]/[action]")]
    [HttpGet]
    public List<ProductDto> GetProducts(int categoryId)
    {
        var products =  _repository.GetProductsByCategory(categoryId);
        var output = new List<ProductDto>();
        foreach (var product in products)
        {
            output.Add(new ProductDto(product));
        }

        return output;
    }

    [Route("api/[controller]/[action]")]
    [HttpPost]
    public int Add(CategoryDto categoryDto)
    {
        return _repository.Add(categoryDto);
    }

    [Route("api/[controller]/[action]")]
    [HttpPost]
    public int AddAttribute(ProductAttributeDto attribute)
    {
        return _repository.AddAttribute(attribute);
    }
}