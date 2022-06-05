using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Repositories
{
    public class Repository : IRepositories
    {
        private readonly Context _context;
        public Repository(Context context)
        {
            _context = context;
        }
        public async Task AddDocument(Document document)
        {
            await _context.AddAsync(document);
            await Task.CompletedTask;
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }
    }
}
