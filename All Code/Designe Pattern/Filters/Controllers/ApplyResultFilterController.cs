using Filters.Filters;
using Microsoft.AspNetCore.Mvc;

namespace Filters.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    //[CustomResultFilter]
    public class ApplyResultFilterController : Controller
    {
        [HttpGet]
        public IActionResult ResultFilter()
        {
            Console.WriteLine(">>> Inside Controller");
            return Ok("Hello from API");
        }
    }
}
