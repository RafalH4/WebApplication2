using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Repositories
{
    public interface IUnitOfWork
    {
        IRepositories Repositories { get; }
        Task Save();
        Task Dispose();
    }
}
