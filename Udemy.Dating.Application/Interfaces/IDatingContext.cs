using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Udemy.Dating.Domain;

namespace Udemy.Dating.Application.Interfaces
{
    public interface IDatingContext
    {
        DbSet<Value> Values { get; set; }
        DbSet<User> Users { get; set; }

        int SaveChanges();
    }
}
