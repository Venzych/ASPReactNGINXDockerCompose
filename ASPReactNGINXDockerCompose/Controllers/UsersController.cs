using Microsoft.AspNetCore.Mvc;

namespace ASPReactNGINXDockerCompose.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        [HttpGet]
        public IActionResult GetUser()
        {
            var users = new[]
            {
                new { name = "Oleg"},
                new { name = "Kirill"}
            };
            return Ok(users);
        }
    }
}
