using CodeNetCore.Data.Interfaces;
using CodeNetCore.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;
using CodeNetCore.Data.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CodeNetCore.Data.Entites
{
    [Table("Products")]
    public class Product : DomainEntity<int>, INameable, ISwitchable, IHasSeoMetaData, IDateTracking, IOrdable, IMutiLanguage<int>
    {
         
        public string Name { get; set; }
        [Required]
        public int CategoryId { set; get; }
        [ForeignKey("CategoryId")]
        public virtual ProductCategory ProductCategory { set; get; }
        [StringLength(500)]
        public string Code { get; set; }
        [StringLength(200)]
        public string Description { get; set; }
         public string Info { get; set; }
        public string Content { get; set; }
        public string Parameter { get; set; }
        [StringLength(250)]
        public string ImageDetail { get; set; }
        [StringLength(250)]

        public string ImageThumbs { get; set; }
        [Required]
        [DefaultValue(0)]
        public decimal? Price { get; set; }
        [Required]
        [DefaultValue(0)]
        public decimal? PriceSale { get; set; }
        [StringLength(250)]
        public string NotePrice { get; set; }
        [DefaultValue(0)]
        public int Warranty { get; set; }
        [DefaultValue(0)]
        public int? Age { get; set; }
 
        public string Sale { get; set; }
        [StringLength(250)]

        public string Size { get; set; }
        public bool? Vat { get; set; }
        public bool? New { get; set; }
        public bool? ProductSale { get; set; }
        public bool? HomeFlag { get; set; }
        public int Ord {set;get;}
        public DateTime DateCreated {set;get;}
        public DateTime DateModified {set;get;}
        [StringLength(200)]
        public string TitleMeta {set;get;}
        [StringLength(300)]
        public string KeywordMeta {set;get;}
        [StringLength(300)]
        public string DescriptionMeta {set;get;}
        [Column (TypeName ="varchar(255)")]
        [StringLength(255)]
        public string Alias {set;get;}
        public Status Status {set;get;}
        public int? LanguageId {set;get;}
        [DefaultValue(0)]
        public int? ViewCount { set; get; }
        public Active Active { set; get; }
        [StringLength(255)]
        public string Tag { set; get; }
        public virtual ICollection<ProductTag> ProductTags { set; get; }
         int IMutiLanguage<int>.LanguageId { set; get; }
    }
}

 