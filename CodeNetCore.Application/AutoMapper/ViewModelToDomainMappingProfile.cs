using AutoMapper;
using CodeNetCore.Application.ViewModels.Product;
using CodeNetCore.Data.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNetCore.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile:Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ProductCategoryViewModel, ProductCategory>().
                ConstructUsing(x => new ProductCategory(x.Name, x.ParentId, x.Description, x.Content, x.Images, x.Icon, x.HomeFlag, x.Ord, x.DateCreated, x.DateModified, x.Alias, x.TitleMeta, x.KeywordMeta, x.DescriptionMeta, x.LanguageId, x.Status));
        }
    }
}
