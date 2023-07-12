using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using OnlineStoreBackendAPI.Models.DTO;

namespace OnlineStoreBackendAPI.Controllers;

public class CartController : ControllerBase
{
    [HttpGet]
    [Route("api/[controller]/[action]")]
    public List<ProductDto> GetProducts(int cartId)
    {
        var dtos = new List<ProductDto>();
        dtos.Add(new ProductDto());
        dtos.Add((new ProductDto()));
        return dtos;
    } 

}