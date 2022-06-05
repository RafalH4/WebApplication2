using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Context _context;
        public UnitOfWork(Context context)
        {
            _context = context;
            Repositories = new Repository(_context);
        }

        public IRepositories Repositories { get; }
        public async Task Dispose()
        {
            await _context.DisposeAsync();
            await Task.CompletedTask;
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
            await Task.CompletedTask;
        }
    }
}
