using Microsoft.AspNetCore.Mvc;

namespace SmartSchool_WebAPI.Controllers
{
    [ApiController]
    [Route("/aluno")]
    public class AlunoController: ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("aluno");
        }
    }
}