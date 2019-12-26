using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Dating.Application.Interfaces;
using Udemy.Dating.Domain;

namespace Udemy.Dating.Application.Repositories
{
    public class ValuesRepository : IValuesRepository
    {
        private readonly List<Value> _values = new List<Value>
        {
            new Value { Id = 1, Name = "Value 2" },
            new Value { Id = 2, Name = "Value 245" },
            new Value { Id = 3, Name = "Value 122" },
        };

        public async Task<Value> GetValueAsync(Guid id)
        {
            return await Task.FromResult(_values.FirstOrDefault(x => x.Id == 1));
        }
    }
}
