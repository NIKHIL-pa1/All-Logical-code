using DapperDemo.Model;
using DapperDemo.Repo;
using Microsoft.AspNetCore.Mvc;

namespace DapperDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private readonly EmployeeRepository _repo;

        public EmployeeController(EmployeeRepository emp)
        {
            _repo = emp;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var res = await _repo.GetAll();
            return Ok(res);
        }

        [HttpPost]
        public async Task<IActionResult> AddRec([FromBody] EmployeeDTO emp)
        {
            var Empl = new EmployeeDTO
            {
                Name = emp.Name,
                Salary = emp.Salary
            };
            await _repo.Add(Empl);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Del(int id)
        {
            var res = await _repo.Delete(id);

            if(res == 0)
                return NotFound("Employee not found");
            return Ok("Deleted");
        }
    }
}
