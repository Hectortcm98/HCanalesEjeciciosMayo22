using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Vistas.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class Vista1Controller : Controller
    {


        [HttpGet]
        public IActionResult Vista01()
        {
            return View();
        }


        [HttpPost]
        [Route("Add")]
        public IActionResult Add([FromBody] ML.Usuario usuario)
        {
            if(usuario == null)
            {
                return BadRequest("El usuario Proporcionado es nulo");
            }

            var resultado  = BL.Usuario.Add(usuario);

            if (resultado.Item1)
            {
                return Ok(resultado.Item1);
            }
            else
            {
                return BadRequest("El usuario Proporcionado es nulo");
            }          
        }
    }
}
