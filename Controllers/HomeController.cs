using Microsoft.AspNetCore.Mvc;
using trabajo2.Models;

namespace trabajo2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(PromedioViewModel vm)
        {
            return View(vm);
        }
        public IActionResult Resultado(int Materia1, int Materia2, int Materia3)
        {

            return Ok((Materia1 + Materia2 + Materia3) / 3);
        }

    }
}
