
using System;

namespace DAL
{
    public interface IUnitOfWork : IDisposable
    {
        
        int Complete();
    }
}