using System;
using System.Threading.Tasks;
using Udemy.Dating.Domain;

namespace Udemy.Dating.Application.Interfaces
{
    public interface IValuesRepository
    {
        Task<Value> GetValueAsync(Guid id);
    }
}