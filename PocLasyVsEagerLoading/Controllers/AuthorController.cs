using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PocLasyVsEagerLoading.Services;

namespace PocLasyVsEagerLoading.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IService _service;

        public AuthorController(IService service)
        {
            _service = service;
        }

        [HttpGet("EagerLoading")]
        public IActionResult GetAll()
        {
            var authors = _service.EagerlyGetAll();
            return Ok(authors);
        }

        [HttpGet("LazyLoading")]
        public IActionResult Get()
        {
            var authors = _service.LazilyGetAll();
            return Ok(authors);
        }

    }
}
