using CodeNetCore.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNetCore.Data.Interfaces
{
    public interface ISwitchTable
    {
        Active Active { set; get; }
        Status Status { set; get; }
    }
}
