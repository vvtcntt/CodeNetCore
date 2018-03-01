using CodeNetCore.Data.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using CodeNetCore.Data.Enums;

namespace CodeNetCore.Data.Entites
{
    [Table("AppUsers")]
    public class AppUser : IdentityUser<Guid>, IDateTracking, ISwitchTable
    {
        public string FullName { get; set; }

        public DateTime? BirthDay { set; get; }

        public decimal Balance { get; set; }

        public string Avatar { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public Active Active { get; set; }
        public Status Status { get; set; }
    }
}
