using Microsoft.AspNetCore.Mvc;

namespace SmartSchool_WebAPI.Controllers
{
    [ApiController]
    [Route("/professor")]
    public class ProfessorController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("aluno");
        }
    }
}