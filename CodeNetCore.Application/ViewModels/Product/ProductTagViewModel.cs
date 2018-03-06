using CodeNetCore.Application.ViewModels.Tag;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNetCore.Application.ViewModels.Product
{
    public class ProductTagViewModel
    {
        public int Id { set; get; }
        public int ProductId { set; get; }
        public string TagId { set; get; }

        public ProductViewModel Product { set; get; }

        public TagViewModel Tag { set; get; }
    }
}
