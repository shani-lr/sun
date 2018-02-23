using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Sun.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class SunController : Controller
    {
        [HttpGet]
        public IActionResult Test()
        {
            return Ok("You touched the sun");
        }
    }
}