using AutoMapper;
using ShopOnSale.services.Models;
using ShopOnSale.services.Models.ViewModels;

namespace ShopOnSale.api.Map
{
    public static class MapperAuto
    {
        public static void InitialConfigure()
        {
         //   Mapper.Initialize( cfg => 
            //   cfg.CreateMap<ItemModel, ViewItemModel>()
           //         .ForMember(x => x.Category, opt=> opt.MapFrom(src => src.Category)));
               Mapper.Initialize( cfg => 
                   cfg.CreateMap<ItemModel, ViewItemModel>());
        }
    }
}