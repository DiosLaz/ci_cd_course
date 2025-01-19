using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace pipeline_crashcourse.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        [HttpGet("/Login")]
        public IActionResult Logins(string username, string password)
        {
            return Ok($@"Your user name is {username} and password is {password}");
        }


        [HttpGet("/Register")]
        public IActionResult Registers()
        {
            return Ok("Works fine, register updated");
        }

        [HttpGet("/RegisterAll")]
        public IActionResult RegisterALl(string data)
        {
            return Ok(data);
        }
    }
}
