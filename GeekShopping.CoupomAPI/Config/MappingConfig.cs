﻿using AutoMapper;
using GeekShopping.CouponAPI.Data.ValueObject;
using GeekShopping.CouponAPI.Model;

namespace GeekShopping.CouponAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponVO, Coupon>();
            });
            return mappingConfig;

        }
    }
}
