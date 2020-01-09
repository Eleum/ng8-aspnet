using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Udemy.Dating.Api.Models.External;

namespace Udemy.Dating.Api.Services
{
    public class FacebookAuthService : IFacebookAuthService
    {
        private const string TokenValidationUrl = "https://graph.facebook.com/debug_token?input_token={0}&access_token={1}|{2}";
        private const string UserInfoUrl = "https://graph.facebook.com/me?fields=first_name,last_name,picture,email&access_token={0}";
        private readonly FacebookAuthSettings _facebookAuthSettings;
        private readonly IHttpClientFactory _httpClientFactory;

        public FacebookAuthService(FacebookAuthSettings facebookAuthSettings, IHttpClientFactory httpClientFactory)
        {
            _facebookAuthSettings = facebookAuthSettings;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<FacebookUserInfo> GetUserInfoAsync(string token)
        {
            var formattedUrl = string.Format(UserInfoUrl, token);

            var result = await _httpClientFactory.CreateClient().GetAsync(formattedUrl);
            result.EnsureSuccessStatusCode();

            var content = await result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<FacebookUserInfo>(content);
        }

        public async Task<FacebookTokenValidationResult> ValidateAccessTokenAsync(string token)
        {
            var formattedUrl = string.Format(TokenValidationUrl, token, _facebookAuthSettings.AppId, _facebookAuthSettings.AppSecret);

            var result = await _httpClientFactory.CreateClient().GetAsync(formattedUrl);
            result.EnsureSuccessStatusCode();
            
            var content = await result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<FacebookTokenValidationResult>(content);
        }
    }
}
