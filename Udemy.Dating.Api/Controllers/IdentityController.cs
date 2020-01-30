using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Udemy.Dating.Api.Contracts.V1;
using Udemy.Dating.Api.Contracts.V1.Requests;

namespace Udemy.Dating.Api.Controllers
{
    [ApiController]
    public class IdentityController : ControllerBase
    {
        [HttpPost(ApiRoutes.Identity.Register)]
        public async Task<IActionResult> Register(UserRegistrationRequest request)
        {
            return Ok();
        }
    }
}
