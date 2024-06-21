using Microsoft.AspNetCore.Mvc;

namespace Vistas.Controllers
{
    public class PruebaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
