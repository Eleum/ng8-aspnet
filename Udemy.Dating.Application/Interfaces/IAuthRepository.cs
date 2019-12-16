using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Udemy.Dating.Domain;

namespace Udemy.Dating.Application.Interfaces
{
    public interface IAuthRepository
    {
        Task<User> Register(User user, string password);

        Task<User> Login(string username, string password);

        Task<bool> IsUserExists(string username);
    }
}
