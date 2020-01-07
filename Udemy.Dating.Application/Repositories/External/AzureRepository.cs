using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.KeyVault;
using Microsoft.Azure.KeyVault.Models;
using Microsoft.Azure.Services.AppAuthentication;
using Udemy.Dating.Application.Interfaces;

namespace Udemy.Dating.Application.Repositories.External
{
    public class AzureRepository : IAzureRepository
    {
        private const string AzureKeyVaultUrl = "https://IDC-KeyVault.vault.azure.net/secrets/{0}";

        public async Task<string> GetKeyVaultSecretAsync(string secretId)
        {
            try
            {
                var tokenProvider = new AzureServiceTokenProvider();
                var keyVaultClient = new KeyVaultClient(
                    new KeyVaultClient.AuthenticationCallback(tokenProvider.KeyVaultTokenCallback)
                );

                var secret = await keyVaultClient.GetSecretAsync(string.Format(AzureKeyVaultUrl, secretId)).ConfigureAwait(false);
                return secret.Value;
            }
            catch (KeyVaultErrorException e)
            {
                return e.Message;
            }
        }
    }
}
