using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using ShopOnSale.services.Interface;
using ShopOnSale.services.Models;
using ShopOnSale.services.Models.ViewModels;

namespace ShopOnSale.services.Services
{
    public class ShopServices : IShopServices
    {
        private IGenericRepository<ItemModel> _shopServices;

        public ShopServices(IGenericRepository<ItemModel> shopServices)
        {
            this._shopServices = shopServices;
        }    
        public IEnumerable<ViewItemModel> ShowAllProducts()
        {
            var _allProducts = _shopServices.GetAll();
            return Mapper.Map<IEnumerable<ItemModel>, IEnumerable<ViewItemModel>>(_allProducts);
        }

        public ViewItemModel GetById(int _id)
        {
            return Mapper.Map<ItemModel, ViewItemModel>(_shopServices.GetById(_id));
        }
    }
}