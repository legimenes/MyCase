using System;

namespace LGG.MyCase.SharedKernel.Interfaces.Transaction
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}