using EShop.Service;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EShop.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetUser([FromServices] IUserService userService)
        {
            var result = await userService.GetUsersAsync();
            return Ok(result);
        }
    }
}
