using ShopOnSale.services.Enums;
using ShopOnSale.services.Models.Base;

namespace ShopOnSale.services.Models
{
    public class ItemModel : Entity
    {
        public string Name { get; set; }
        public StatusEnum StatusOrder { get; set; }
        public CategoryEnum Category { get; set; }
        public double Price { get; set; }
        public string PictureSrc { get; set; }

    }
}