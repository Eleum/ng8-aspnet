using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Udemy.Dating.Api.Models;

namespace Udemy.Dating.Api.Data
{
    public class DatingContext : DbContext
    {
        public DatingContext(DbContextOptions<DatingContext> options) : base(options)
        {
            
        }

        public DbSet<Value> Values { get; set; }
    }
}
