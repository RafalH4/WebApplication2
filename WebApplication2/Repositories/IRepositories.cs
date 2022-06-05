﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Repositories
{
    public interface IRepositories
    {
        Task AddDocument(Document document);
        Task SaveChanges();
    }
}
