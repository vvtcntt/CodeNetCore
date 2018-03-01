﻿using CodeNetCore.Data.Interfaces;
using CodeNetCore.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using CodeNetCore.Data.Enums;

namespace CodeNetCore.Data.Entites
{
    [Table("Feedbacks")]
    public class Feedback : DomainEntity<int>, ISwitchTable, IDateTracking
    {

        [StringLength(250)]
        [Required]
        public string Name { set; get; }

        [StringLength(250)]
        public string Email { set; get; }

        [StringLength(500)]
        public string Message { set; get; }

         public DateTime DateCreated { set; get; }
        public DateTime DateModified { set; get; }
        public Active Active { set; get; }
        public Status Status { set; get; }
    }
}
