
using System;

namespace DAL
{
    public interface IUnitOfWork : IDisposable
    {
        //IProjectParticipa
        int Complete();
    }
}