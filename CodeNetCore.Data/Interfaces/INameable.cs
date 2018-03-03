using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CodeNetCore.Data.Interfaces
{
    public interface INameable
    {
        [StringLength(150)]
        [Required]
        string Name { set; get; }
    }
}
