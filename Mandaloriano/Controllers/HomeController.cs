using Mandaloriano.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Mandaloriano.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Misiones()
        {
            return View(new clsMisionesVM());
        }

    }
}