﻿using GeekShopping.ProductAPI.Data.ValueObject;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GeekShopping.ProductAPI.Repository.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductVO>> FindAll();
        Task<ProductVO> FindById(long id);
        Task<ProductVO> Create(ProductVO vo);
        Task<ProductVO> Update(ProductVO vo);
        Task<bool> Delete(long id);
    }
}
