using CodeNetCore.Application.ViewModels.Product;
using CodeNetCore.Utilities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNetCore.Application.Interfaces
{
    public interface  IProductService:IDisposable
    {
        List<ProductViewModel> GetAll();
        PagedResult<ProductViewModel> GetAllPaging(int? categogyId,string keyword, int page, int pageSize);
    }
}
