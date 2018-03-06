using AutoMapper;
using CodeNetCore.Application.ViewModels.Product;
using CodeNetCore.Data.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNetCore.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile:Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ProductCategory, ProductCategoryViewModel>();
        }
    }
}
