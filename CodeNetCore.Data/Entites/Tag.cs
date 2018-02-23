using CodeNetCore.Data.Interfaces;
using CodeNetCore.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CodeNetCore.Data.Entites
{
    public class Tag : DomainEntity<string>, INameTable
    {
        [StringLength(50)]
        [Required]
        public string Name { set; get; }
        [StringLength(50)]
        [Required]
        public string Type { set; get; }
        public virtual ICollection<ProductTag> ProductTags { set; get; }
    }
}
