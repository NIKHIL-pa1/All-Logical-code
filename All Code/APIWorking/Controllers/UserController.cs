using APIWorking.Repository.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace APIWorking.Controllers
{
    [ApiController]
   // [Route("[controller]")]
    
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _Service;

        public UserController(IUserService service)
        {
            this._Service = service;
        }
        [HttpGet]
        public IActionResult GetUsersData()
        {
            return Ok(_Service.GetUsers());
        }
    }
}
