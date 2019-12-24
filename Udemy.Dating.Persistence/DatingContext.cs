using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Udemy.Dating.Application.Interfaces;
using Udemy.Dating.Domain;

namespace Udemy.Dating.Persistence
{
    public class DatingContext : DbContext, IDatingContext
    {
        public DatingContext(DbContextOptions<DatingContext> options) : base(options) { }

        public DbSet<Value> Values { get; set; }
        public DbSet<User> Users { get; set; }

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }
    }
}
