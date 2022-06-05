using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WebApplication2.Models;
using WebApplication2.Repositories;

namespace WebApplication2.Services
{
    public class Service : IService
    {
        public readonly IUnitOfWork _repo;
        public Service(IUnitOfWork repo)
        {
            _repo = repo;  
        }
        public async Task AddFirstDoc()
        {
            var pages = new List<Page>()
            {
                new Page{Name="Page11"},
                new Page{Name="Page12"},
                new Page{Name="Page13"}
            };

            var document1 = new Document
            {
                Name = "Document1",
                Pages = pages
            };
            try
            {
                await _repo.Repositories.AddDocument(document1);
                Thread.Sleep(10000);
                await _repo.Save();
            }catch(Exception ex)
            {

            }

            await Task.CompletedTask;
        }

        public async Task AddSecondDoc()
        {
            var pages = new List<Page>()
            {
                new Page{Name="Page21"},
                new Page{Name="Page22"},
                new Page{Name="Page23"}
            };

            var document2 = new Document
            {
                Name = "Document2",
                Pages = pages
            };
            try
            {
                await _repo.Repositories.AddDocument(document2);
                await _repo.Save();
            }
            catch(Exception ex)
            {

            }
            await Task.CompletedTask;
        }
    }
}
