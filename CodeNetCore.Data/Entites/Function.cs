using CodeNetCore.Data.Interfaces;
using CodeNetCore.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using CodeNetCore.Data.Enums;

namespace CodeNetCore.Data.Entites
{
    [Table("Functions")]
    public class Function : DomainEntity<string>, ISwitchTable, IOrdTable
    {
        public Function()
        {

        }
        public Function(string name, string url, string parentId, string iconCss, int ord)
        {
            this.Name = name;
            this.URL = url;
            this.ParentId = parentId;
            this.IconCss = iconCss;
            this.Ord = ord;
            this.Active = Active.Active;
         }
        [Required]
        [StringLength(128)]
        public string Name { set; get; }

        [Required]
        [StringLength(250)]
        public string URL { set; get; }


        [StringLength(128)]
        public string ParentId { set; get; }

        public string IconCss { get; set; }
        public Active Active { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Status Status { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Ord { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
