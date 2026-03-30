using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;
using Microsoft.EntityFrameworkCore;
using Reesp_Api_Crud.Data;
using Reesp_Api_Crud.Model;

namespace Reesp_Api_Crud.Controllers
{
    //[EnableRateLimiting("fixed")]
    [ApiVersion("1.0")]
    [ApiController]
    [Route("api/v{version:apiVersion}/[Controller]")]
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;
        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }

        //[EnableRateLimiting("fixed")]
        [HttpPost]
        public IActionResult Index(student stud)
        {
            _context.Students.Add(stud);
            _context.SaveChanges();
            return Ok();
        }

        [EnableRateLimiting("fixed")]
        [HttpGet]
        public IActionResult Get()
        {
            var student = _context.Students.AsNoTracking().ToList();
            return Ok(student);
        }

        [EnableRateLimiting("fixed")]
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var stud = _context.Students.Find(id);
            if (stud == null)
                return NotFound();
            return Ok(stud);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id, student studands)
        {
            var stud = _context.Students.Find(id);
            if(stud == null)
                return NotFound();

            stud.Name = studands.Name;
            stud.Age =  studands.Age;
            stud.Course = studands.Course;

            _context.SaveChanges();

            return Ok(stud+"updated");
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var stud = _context.Students.Find(id);

            if(stud ==  null)
                return NotFound();
            _context.Students.Remove(stud);
            _context.SaveChanges();

            return Ok("Deleted");
        }
    }
}
