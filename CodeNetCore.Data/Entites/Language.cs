using CodeNetCore.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using CodeNetCore.Data.Enums;
using CodeNetCore.Infrastructure.SharedKernel;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeNetCore.Data.Entites
{
    [Table("Languages")]
    public class Language : DomainEntity<string>, ISwitchable
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        public bool IsDefault { get; set; }

        public string Resources { get; set; }
        public Active Active { get; set; }
        public Status Status { get; set; }
    }
}
