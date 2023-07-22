using Microsoft.AspNetCore.Mvc;
using OnlineStoreBackendAPI.Models.Enums;

namespace OnlineStoreBackendAPI.Controllers;

public class OrderController : ControllerBase
{//TODO implement controller
    [Route("/api/[controller]/[action]")]
    [HttpPost]
    public int FinalizeOrder(int orderId, ShippingMethod shippingMethod = ShippingMethod.NovaPoshta)
    {
        return 1;
    }
}