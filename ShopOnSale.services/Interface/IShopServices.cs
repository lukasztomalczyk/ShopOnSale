using System.Collections.Generic;
using ShopOnSale.services.Models;

namespace ShopOnSale.services.Interface
{
    public interface IShopServices
    {
        IEnumerable<ItemModel> ShowAllProducts();
    }
}