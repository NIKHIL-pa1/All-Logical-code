using Microsoft.AspNetCore.Mvc;

namespace Filters.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ApplyExecptionFilterController : Controller
    {
        [HttpGet("success")]
        public IActionResult Success()
        {
            return Ok("API working");
        }

        [HttpGet("error")]
        public IActionResult Error()
        {
            Console.WriteLine(">>> Inside Controller");
            throw new Exception("Test exception occurred");
        }
    }
}
