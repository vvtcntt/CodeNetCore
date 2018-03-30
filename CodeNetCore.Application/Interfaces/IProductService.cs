using CodeNetCore.Application.ViewModels.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNetCore.Application.Interfaces
{
    public interface  IProductService:IDisposable
    {
        List<ProductViewModel> GetAll();
       
    }
}
