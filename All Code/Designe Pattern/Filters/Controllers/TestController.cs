using Microsoft.AspNetCore.Mvc;
using Filters.Filters;

namespace Filters.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    public class TestController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            Console.WriteLine(">>> Inside Controller");
            return Ok("Hello");
        }
    }
}
