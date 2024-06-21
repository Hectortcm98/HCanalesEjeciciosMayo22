using Microsoft.AspNetCore.Mvc;

namespace Vistas.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Form()
        {
            return View();
        }
    }
}
