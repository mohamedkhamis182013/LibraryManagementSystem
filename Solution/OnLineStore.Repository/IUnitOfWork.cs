using System;
using System.Data.Entity;

namespace OnLineStore.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();

    }
}
