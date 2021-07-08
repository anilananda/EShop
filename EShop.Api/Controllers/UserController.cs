using EShop.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EShop.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetUser()
        {
            List<User> users = new List<User>()
            {
                new User()
                {
                    Id=1,
                    UserName="Anilananda"
                },
                new User()
                {
                    Id=2,
                    UserName="Arun"
                }
            };
            return Ok(users);
        }
    }
}
