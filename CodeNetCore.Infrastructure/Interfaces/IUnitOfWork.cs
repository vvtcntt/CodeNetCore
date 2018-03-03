using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNetCore.Infrastructure.Interfaces
{
    public interface  IUnitOfWork:IDisposable
    {// call save changer db context
        void Commit();
    }
}
