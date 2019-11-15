using MOD.DATA.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MOD.DATA
{
    public interface IUnitOfWork
    {
        bool Flag { get; set; }
        ITrainingRepository Training { get; }
        int Complete();
        void Dispose();
    }
}
