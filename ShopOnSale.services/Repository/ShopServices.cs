using System.Collections.Generic;
using ShopOnSale.services.Interface;
using ShopOnSale.services.Models;

namespace ShopOnSale.services.Repository
{
    public class ShopServices : IShopServices
    {
        private IGenericRepository<ShopServices> _shopServices;

        public ShopServices(IGenericRepository<ShopServices> shopServices)
        {
            this._shopServices = shopServices;
        }
        public IEnumerable<ItemModel> ShowAllProducts()
        {
            throw new KeyNotFoundException();
        }
    }
}