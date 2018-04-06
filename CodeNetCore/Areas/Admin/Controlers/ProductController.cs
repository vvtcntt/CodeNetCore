using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeNetCore.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CodeNetCore.Areas.Admin.Controlers
{
     public class ProductController :BaseController
    {
        IProductService _productService;
        IProductCategoryService _productCategoryService;
        public ProductController(IProductService productService, IProductCategoryService productCategoryService)
        {
            _productService = productService;
            _productCategoryService = productCategoryService;
        }
        public IActionResult Index()
        {
            return View();
        }
        #region Ajax
        [HttpGet]
        public IActionResult GetAll()
        {
            var model = _productService.GetAll();
            return new OkObjectResult(model);
        }
        [HttpGet]
        public IActionResult GetAllCategory()
        {
            var model = _productCategoryService.GetAll();
            return new OkObjectResult(model);
        }
        [HttpGet]
        public IActionResult GetAllPaging(int?categoryId,string keyword,int page,int pageSize)
        {
            var model = _productService.GetAllPaging(categoryId,keyword,page,pageSize);
            
            return new OkObjectResult(model);
        }
        #endregion
    }
}