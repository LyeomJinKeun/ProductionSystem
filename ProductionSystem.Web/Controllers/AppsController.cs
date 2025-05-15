using Microsoft.AspNetCore.Mvc;

namespace ProductionSystem.Web.Controllers
{
    public class AppsController : Controller
    {
        public IActionResult System() => View("UnderConstruction");
        public IActionResult Recipe() => View("UnderConstruction");
        public IActionResult Monitor() => View("UnderConstruction");
        public IActionResult Inspection() => View("UnderConstruction");
    }
}