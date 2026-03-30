using Microsoft.AspNetCore.Mvc;

namespace TaskManagement.Api.Controllers
{
    [ApiController]
    [Route("api/tasks")]
    public class TaskController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
