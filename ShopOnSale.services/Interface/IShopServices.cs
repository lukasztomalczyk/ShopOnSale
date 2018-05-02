using System.Collections.Generic;
using ShopOnSale.services.Models.ViewModels;

namespace ShopOnSale.services.Interface
{
    public interface IShopServices
    {
        IEnumerable<ViewItemModel> ShowAllProducts();
        ViewItemModel GetById(int _id);
    }
}