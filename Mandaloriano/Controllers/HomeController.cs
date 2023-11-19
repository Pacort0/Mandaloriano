using Mandaloriano.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Mandaloriano.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Vista que se muestra al entrar en la página
        /// A la vista se le pasa un ViewBag con un valor booleano 'false' porque aún no se ha elegido ninguna misión
        /// </summary>
        /// <returns>Devuelve una vista con un objeto clsMisionesVM pasado como modelo</returns>
        public IActionResult Misiones()
        {
            ViewBag.InfoMision = false;
            return View(new clsMisionesVM());
        }
        /// <summary>
        /// Vista que se muestra una vez se elige una misión (HTTPPOST)
        /// A la vista se le pasa un ViewBag con un valor booleano 'true' porque ya se ha elegido una misión
        /// Se hace un foreach para crear un objeto clsMisionesVM con las propiedades de la mision escogida en el formulario
        /// </summary>
        /// <param name="idMision">Se recoge el id de la misión recogida en el dropdownlist del formulario</param>
        /// <returns>Se devuelve una vista a la que se le pasa como modelo un objeto clsMisionesVM 
        /// con las mismas propiedades que la misión escogida en el formulario</returns>
        [HttpPost]
        public IActionResult Misiones(int idMision)
        {
            clsMisionesVM mision = new clsMisionesVM();
            foreach (var item in mision.ListaMisiones)
            {
                if (item.IdMision == idMision)
                {
                    mision.IdMision = item.IdMision;
                    mision.NombreMision = item.NombreMision;
                    mision.RecompensaMision = item.RecompensaMision;
                    mision.ObjetivoMision = item.ObjetivoMision;
                }
            }
            ViewBag.InfoMision = true;
            return View(mision);
        }
    }
}