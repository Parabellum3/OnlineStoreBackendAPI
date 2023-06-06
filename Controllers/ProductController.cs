using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineStoreBackendAPI.Models;

namespace OnlineStoreBackendAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet(Name = "GetProductDescription")]
        public BaseProductM GetById(int productId)
        {
            
        }
    }
}
