using Microsoft.AspNetCore.Mvc;
using ProductionSystem.Web.Models;

namespace ProductionSystem.Web.Controllers
{
    public class AppsController : Controller
    {
        public IActionResult UnderConstruction()
        {
            return View(); // => Views/Apps/UnderConstruction.cshtml 를 찾음
        }

        public IActionResult System() => View("SystemManager");
        public IActionResult Recipe() => View("SystemManager/UserRegister");
        public IActionResult Monitor() => View("UnderConstruction");
        public IActionResult Inspection() => View("UnderConstruction");
    }
}