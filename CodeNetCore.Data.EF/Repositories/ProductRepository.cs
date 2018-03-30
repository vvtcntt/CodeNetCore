using CodeNetCore.Data.Entites;
using CodeNetCore.Data.iRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNetCore.Data.EF.Repositories
{
    public class ProductRepository : EFRepository<Product, int>,IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }
    }
}
