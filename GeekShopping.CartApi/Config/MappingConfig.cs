using AutoMapper;
using GeekShopping.CartAPI.Data.ValueObject;
using GeekShopping.CartAPI.Model;

namespace GeekShopping.CartAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CartDetailVO, CartDetail>().ReverseMap();
                config.CreateMap<CartHeaderVO, CartHeader>().ReverseMap();
                config.CreateMap<CartVO, CartVO>().ReverseMap();
                config.CreateMap<ProductVO, Product>();
            });
            return mappingConfig;

        }
    }
}
