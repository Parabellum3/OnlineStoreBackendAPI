using Microsoft.AspNetCore.Mvc;
using OnlineStoreBackendAPI.DataAccess.Abstracts;
using OnlineStoreBackendAPI.Models.Enums;

namespace OnlineStoreBackendAPI.Controllers;

public class OrderController : ControllerBase
{
    private readonly IOrderRepository _repository;
    
    public OrderController(IOrderRepository repository)
    {
        _repository = repository;
    }
    [Route("/api/[controller]/[action]")]
    [HttpPost]
    public ActionResult FinalizeOrder(int orderId, ShippingMethod shippingMethod = ShippingMethod.NovaPoshta) {
        return Ok(_repository.Finalize(orderId, shippingMethod));
    }

    [Route("/api/[controller]/[action]")]
    [HttpPost]
    public ActionResult CreateOrderFromCart(int cartId) {
        return Ok(_repository.CreateOrderFromCart(cartId));
    }
    
    [Route("/api/[controller]/[action]")]
    [HttpPost]
    public ActionResult GetByUser(int userId) {
        return Ok(_repository.GetByUser(userId));
    }
    
    
}

