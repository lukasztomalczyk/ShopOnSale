using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopOnSale.Interface.Application;

namespace ShopOnSale.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("/api/[controller]/[action]")]
    public class ProductController : Controller
    {
        [HttpPost]
        public object Buy([FromBody]BuyProductCommand command)
        {
            return new BuyProductCommand(Guid.NewGuid().ToString("N").Substring(0, 20));
        }
    }
}