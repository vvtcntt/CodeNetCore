using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeNetCore.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CodeNetCore.Areas.Admin.Controlers
{
    public class ProductCategoryController : BaseController
    {
        IProductCategoryService _productCategoryService;

        public IActionResult Index()
        {
            return View();
        }
 
        public ProductCategoryController( IProductCategoryService productCategoryService)
        {
            _productCategoryService = productCategoryService;
        }
       
         [HttpGet]
        public IActionResult GetAll()
        {
            var model = _productCategoryService.GetAll();
            return new OkObjectResult(model);
        }
        
        
    }
}