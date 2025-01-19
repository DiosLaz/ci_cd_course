using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace pipeline_crashcourse.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        [HttpGet("/Login")]
        public IActionResult Logins()
        {
            return Ok("Works fines login updated");
        }


        [HttpGet("/Register")]
        public IActionResult Registers()
        {
            return Ok("Works fine, register updated");
        }
    }
}
