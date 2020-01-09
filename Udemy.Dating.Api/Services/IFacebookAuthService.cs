using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Udemy.Dating.Api.Models.External;

namespace Udemy.Dating.Api.Services
{
    public interface IFacebookAuthService
    {
        Task<FacebookTokenValidationResult> ValidateAccessTokenAsync(string token);

        Task<FacebookUserInfo> GetUserInfoAsync(string token);
    }
}
