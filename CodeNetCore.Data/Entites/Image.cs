using CodeNetCore.Data.Interfaces;
using CodeNetCore.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;
using CodeNetCore.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeNetCore.Data.Entites
{ [Table("News")]
    public class Image : DomainEntity<int>, INameable,IOrdable, ISwitchable
    {
        public string Name { set; get; }
        public int CategoryId { set; get; }
        [StringLength(200)]
        public string ImageLink { set; get; }
        public bool? TypeLink { set; get; }
        [StringLength(200)]
        public string Url { set; get; }
         public int Ord { set; get; }
        public Active Active { set; get; }
        public Status Status { set; get; }
        [ForeignKey("CategoryId")]
        public virtual ImageCategory ImageCategories { set; get; }
    }
}
