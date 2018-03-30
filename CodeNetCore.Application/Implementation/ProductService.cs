using AutoMapper.QueryableExtensions;
using CodeNetCore.Application.Interfaces;
using CodeNetCore.Application.ViewModels.Product;
using CodeNetCore.Data.iRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeNetCore.Application.Implementation
{
    public class ProductService : IProductService
    {
        IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<ProductViewModel> GetAll()
        {
            return _productRepository.FindAll(x=>x.ProductCategory).ProjectTo<ProductViewModel>().ToList();
        }
    }
}
