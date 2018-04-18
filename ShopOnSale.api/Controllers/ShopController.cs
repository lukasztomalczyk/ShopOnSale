using Microsoft.AspNetCore.Mvc;
using ShopOnSale.services.Repository;

namespace ShopOnSale.api.Controllers
{
    public class ShopController : Controller
    {
        private ShopServices _shopServices;

        public ShopController(ShopServices shopServices)
        {
            this._shopServices = shopServices;
        }
    }
}