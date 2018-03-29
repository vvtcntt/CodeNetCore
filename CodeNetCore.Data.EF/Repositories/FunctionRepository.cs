using CodeNetCore.Data.Entites;
using CodeNetCore.Data.iRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNetCore.Data.EF.Repositories
{
    public class FunctionRepository : EFRepository<Function, string>, IFunctionRepository
    {
        public FunctionRepository(AppDbContext context) : base(context)
        {
        }
    }
}
