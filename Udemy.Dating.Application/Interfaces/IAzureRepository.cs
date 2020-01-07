using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Dating.Application.Interfaces
{
    public interface IAzureRepository
    {
        Task<string> GetKeyVaultSecretAsync(string secretId);
    }
}
