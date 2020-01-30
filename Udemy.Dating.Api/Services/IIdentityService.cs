using System.Threading.Tasks;
using Udemy.Dating.Domain;

namespace Udemy.Dating.Api.Services
{
    public interface IIdentityService
    {
        Task<AuthenticationResult> RegisterAsync(string email, string password);

        Task<AuthenticationResult> LoginAsync(string email, string password);
    }
}
