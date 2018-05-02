using System;
using ShopOnSale.services.Models.ViewModels.Base;

namespace ShopOnSale.services.Models.ViewModels
{
    public class ViewItemModel : ViewEntity
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string Price { get; set; }
        public string PictureSrc { get; set; }
    }
}