using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Dating.Application.Interfaces;
using Udemy.Dating.Domain;

namespace Udemy.Dating.Application.Repositories.Cached
{
    public class CachedValuesRepository : IValuesRepository
    {
        private readonly IValuesRepository _repository; // ValuesRepository
        private readonly ConcurrentDictionary<Guid, Value> _cache = new ConcurrentDictionary<Guid, Value>();


        public CachedValuesRepository(IValuesRepository repository)
        {
            _repository = repository;
        }

        public async Task<Value> GetValueAsync(Guid id)
        {
            if (_cache.ContainsKey(id))
            {
                return _cache[id];
            }

            var value = await _repository.GetValueAsync(Guid.NewGuid());
            _cache.TryAdd(id, value);

            return value;
        }
    }
}
