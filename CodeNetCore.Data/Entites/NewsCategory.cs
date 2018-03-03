using CodeNetCore.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using CodeNetCore.Data.Enums;
using CodeNetCore.Infrastructure.SharedKernel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeNetCore.Data.Entites
{
    [Table("NewsCategories")]
    public class NewsCategory : DomainEntity<int>, ISwitchable,INameable,IOrdable,IHasSeoMetaData
    {

        public Status Status { set; get; }
        public string Name { set; get; }
        public int Ord { set; get; }
        public string TitleMeta { set; get; }
        public string KeywordMeta { set; get; }
        public string DescriptionMeta { set; get; }
        public string Alias { set; get; }
        [StringLength(250)]

        public string Description { set; get; }
        public virtual ICollection<News> News { set; get; }
    }
}
