using Microsoft.AspNetCore.Mvc;
using Service_Lifetime.SeviceLifetime;

namespace Service_Lifetime.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        private readonly TransientService _transient1;
        private readonly TransientService _transient2;

        private readonly ScopedService _scoped1;
        private readonly ScopedService _scoped2;

        private readonly SingletonService _singleton1;
        private readonly SingletonService _singleton2;

        public TestController(TransientService transient1,
        TransientService transient2,
        ScopedService scoped1,
        ScopedService scoped2,
        SingletonService singleton1,
        SingletonService singleton2)
        {
            _transient1 = transient1;
            _transient2 = transient2;
            _scoped1 = scoped1;
            _scoped2 = scoped2;
            _singleton1 = singleton1;
            _singleton2 = singleton2;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new
            {
                transient1 = _transient1.GetId(),
                transient2 = _transient2.GetId(),
                scoped1 = _scoped1.GetId(),
                scoped2 = _scoped2.GetId(),
                singleton1 = _singleton1.GetId(),
                singleton2 = _singleton2.GetId()

            });
        }
    }
}
