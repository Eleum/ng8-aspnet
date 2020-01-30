using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Udemy.Dating.Domain;

namespace Udemy.Dating.Application.Interfaces
{
    public interface IDatingContext
    {
        DbSet<Value> Values { get; set; }

        int SaveChanges();
        Task<int> SaveChangesAsync();
    }
}
