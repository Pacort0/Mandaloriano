using Mandaloriano.ViewModels;
using Microsoft.AspNetCore.Mvc;

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