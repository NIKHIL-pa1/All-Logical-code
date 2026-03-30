using APIWorking.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace APIWorking.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : Controller
    {
        [HttpPost("login")]
        public IActionResult login(LoginDtos login)
        {
            if (login.Email == "nikhil12@gmail.com" && login.Password == "Nikhil@#20")
                return Ok("Successfull");
            return Unauthorized();
        }
    }
}
