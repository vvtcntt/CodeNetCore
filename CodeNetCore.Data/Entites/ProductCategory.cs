﻿using CodeNetCore.Data.Interfaces;
using CodeNetCore.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;
using CodeNetCore.Data.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CodeNetCore.Data.Entites
{
    [Table("ProductCategories")]
    public class ProductCategory : DomainEntity<int>, INameTable, IHasSeoMetaData, IDateTracking,  IOrdTable, ISwitchTable, IMutiLanguage<int>
    {
        public ProductCategory()
        {
            Products = new List<Product>();
        }
        public string Name { get; set; }
        public int? ParentId { get; set; }
        [StringLength(255)]
        [Required]
        public string Description { get; set; }
        public string Content { get; set; }
        [StringLength(255)]
        public string Images { get; set; }
        [StringLength(255)]
        public string Icon { get; set; }
        public bool? HomeFlag { get; set; }
        public Active Active { set; get; }
        public int Ord { set; get; }
        public DateTime DateCreated { set; get; }
        public DateTime DateModified { set; get; }
        [StringLength(255)]
        public string TitleMeta { set; get; }
        [StringLength(255)]
        public string KeywordMeta { set; get; }
        [StringLength(255)]
        public string DescriptionMeta { set; get; }
        [StringLength(255)]
        public string Alias { set; get; }
        public int LanguageId { set; get; }
        public Status Status { set; get; }
        public virtual ICollection<Product> Products { set; get; }
    }


}

