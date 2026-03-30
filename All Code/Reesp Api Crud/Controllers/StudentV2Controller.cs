using Microsoft.AspNetCore.Mvc;

namespace Reesp_Api_Crud.Controllers
{
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class StudentV2Controller : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("Students from API Version 2 with new features");
        }
    }
}
