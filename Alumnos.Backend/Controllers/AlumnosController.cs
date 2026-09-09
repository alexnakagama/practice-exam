using Alumno.Abstractions.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Alumnos.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnosController(IAlumnosService _service) : ControllerBase
    {
        [HttpGet("GetAllAlumnos")]
        public async Task<IActionResult> GetAllAlumnos()
        {
            var result = await _service.GetAllAlumnosAsync();
            return Ok(result);
        }
    }
}
