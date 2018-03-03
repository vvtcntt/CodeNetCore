using CodeNetCore.Data.Interfaces;
using CodeNetCore.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;
using CodeNetCore.Data.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeNetCore.Data.Entites
{
    public class ImageCategory : DomainEntity<int>, INameable, IOrdable, ISwitchable
    {
        public int Ord { set; get; }
        public Status Status { set; get; }
        string INameable.Name { set; get; }

        public virtual ICollection<Image> Images { set; get; }
    }
}