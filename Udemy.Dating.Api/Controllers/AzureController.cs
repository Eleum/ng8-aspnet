using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Udemy.Dating.Api.Contracts.V1;
using Udemy.Dating.Application.Interfaces;

namespace Udemy.Dating.Api.Controllers
{
    [ApiController]
    public class AzureController : ControllerBase
    {
        private readonly IAzureRepository _azure;

        public AzureController(IAzureRepository azure)
        {
            _azure = azure;
        }

        [HttpGet(ApiRoutes.Azure.Base)]
        public IActionResult Get()
        {
            return Ok("test");
        }

        [HttpGet(ApiRoutes.Azure.KeyVault)]
        public async Task<IActionResult> GetKeyVaultValue([FromQuery]string secretId)
        {
            return Ok(await _azure.GetKeyVaultSecretAsync(secretId));
        }
    }
}
