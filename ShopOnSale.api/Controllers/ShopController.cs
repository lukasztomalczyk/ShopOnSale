using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ShopOnSale.services.Context.Config;
using ShopOnSale.services.Models;
using ShopOnSale.services.Repository;

namespace ShopOnSale.api.Controllers
{
    [Route("Products/ShowProducts")]
    public class ShopController : Controller
    {
        private ShopServices _shopServices;

        public ShopController(ShopServices shopServices)
        {
            this._shopServices = shopServices;
        }

        [HttpGet]
        public IEnumerable<ItemModel> GetAllProducts()
        {
            return _shopServices.ShowAllProducts();
        }
    }
}