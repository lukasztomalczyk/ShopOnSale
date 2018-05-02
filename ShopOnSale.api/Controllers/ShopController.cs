using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ShopOnSale.services.Interface;
using ShopOnSale.services.Models.ViewModels;
using ShopOnSale.services.Services;

namespace ShopOnSale.api.Controllers
{
   // [Produces("application/json")]
    [Route("api/Shop/")]
    public class ShopController : Controller
    {
        private IShopServices _shopServices;

        public ShopController(IShopServices shopServices)
        {
            this._shopServices = shopServices;
        }

        [HttpGet("GetAllProducts")]
        public IEnumerable<ViewItemModel> GetAllProducts()
        {
            return _shopServices.ShowAllProducts();
        }
        
        [HttpGet("ok")]
        public string ok()
        {
            return "ok";
        }

        [HttpGet("GetProduct/{_id:int}")]
        public ViewItemModel GetProductItem(int _id)
        {
            var _item = _shopServices.GetById(_id);

            if (_item != null)
            {
                return _item;
            }
            else
            {
                return null;
            }
        }
    }
}