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
    [Table("Contacts")]
    public class Contact : DomainEntity<string>,ISwitchTable
    {

        [StringLength(250)]
        [Required]
        public string Name { set; get; }

        [StringLength(50)]
        public string Phone { set; get; }

        [StringLength(250)]
        public string Email { set; get; }

        [StringLength(250)]
        public string Website { set; get; }

        [StringLength(250)]
        public string Address { set; get; }

        public string Other { set; get; }

        public double? Lat { set; get; }

        public double? Lng { set; get; }
        public Active Active { set; get; }
        public Status Status { set; get; }
    }
}
