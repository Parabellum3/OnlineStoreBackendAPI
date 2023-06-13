using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineStoreBackendAPI.DataAccess;
using OnlineStoreBackendAPI.Models;

namespace OnlineStoreBackendAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public BaseProduct GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public List<BaseProduct> GetByCategory(int categoryId)
        {
            return new List<BaseProduct>();
        }
    }
}
