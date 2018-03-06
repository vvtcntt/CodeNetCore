using CodeNetCore.Data.Entites;
using CodeNetCore.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNetCore.Data.iRepositories
{
    public interface IProductCategoryRepository:IRepository<ProductCategory,int>
    {
        List<ProductCategory> GetByAlias(string alias);
    }
}
