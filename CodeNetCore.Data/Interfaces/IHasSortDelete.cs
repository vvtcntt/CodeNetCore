using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNetCore.Data.Interfaces
{
    public interface IHasSortDelete
    {
        bool IDeleted { set; get; }
    }
}
