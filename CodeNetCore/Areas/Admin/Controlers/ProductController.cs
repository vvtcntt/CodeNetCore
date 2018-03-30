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
        public ProductController(IProductService productService)
        {
            _productService = productService;
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
        #endregion
    }
}