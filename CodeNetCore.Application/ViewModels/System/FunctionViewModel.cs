using CodeNetCore.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNetCore.Application.ViewModels.Function
{
    public class FunctionViewModel
    {
        public string Id { set; get; }
        public string Name { set; get; }


        public string URL { set; get; }


        public string ParentId { set; get; }

        public string IconCss { get; set; }
        public Status Status { get; set; }
        public int Ord
        {
            get; set;
        }
    }
}
