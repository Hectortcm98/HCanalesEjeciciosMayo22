using Microsoft.AspNetCore.Mvc;

namespace Vistas.Controllers
{

    [Route("api/[controller]/")]
    [ApiController]
    public class Vista2Controller : Controller
    {
        public IActionResult Vista02()
        {
            return View();
        }

        [HttpPost]
        [Route("Add2")]
        public IActionResult Add([FromBody] ML.Usuario2 usuario)
        {
            if (usuario == null)
            {
                return BadRequest("El usuario Proporcionado es nulo");
            }

            var resultado = BL.Usuario2.Add(usuario);

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
