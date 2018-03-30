using CodeNetCore.Data.Entites;
using CodeNetCore.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace CodeNetCore.Data.iRepositories
{
    public interface IProductRepository : IRepository<Product, int>
    {
         
    }
}
