using CodeNetCore.Data.Interfaces;
using CodeNetCore.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;
using CodeNetCore.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeNetCore.Data.Entites
{
    [Table("News")]
    public class News : DomainEntity<int>, INameable, ISwitchable, IDateTracking, IHasSeoMetaData, IOrdable
    {
        public int Ord { set; get; }
        public string TitleMeta { set; get; }
        public string KeywordMeta { set; get; }
        public string DescriptionMeta { set; get; }
        public string Alias { set; get; }
        public DateTime DateCreated { set; get; }
        public DateTime DateModified { set; get; }
        public Status Status { set; get; }
        public string Name { set; get; }
        public int? CategoryId { set; get; }
        [StringLength(200)]

        public string Description { set; get; }
        public string Content { set; get; }
        public int? ViewCount { set; get; }
        public bool? ViewHomes { set; get; }
        [StringLength(200)]

        public string Image { set; get; }
        [ForeignKey("CategoryId")]
        public virtual NewsCategory NewsCategories { set; get; }
    }
}
