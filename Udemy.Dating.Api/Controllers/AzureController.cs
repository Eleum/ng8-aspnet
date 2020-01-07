using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Udemy.Dating.Application.Interfaces;

namespace Udemy.Dating.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AzureController : ControllerBase
    {
        private readonly IAzureRepository _azure;

        public AzureController(IAzureRepository azure)
        {
            _azure = azure;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("test");
        }

        [HttpGet("keyvault")]
        public async Task<IActionResult> GetKeyVaultValue([FromQuery]string secretId)
        {
            return Ok(await _azure.GetKeyVaultSecretAsync(secretId));
        }
    }
}
