using Microsoft.AspNetCore.Mvc;

namespace ProductionSystem.Web.Controllers
{
    public class HomeController : Controller
    {
        //라우팅 설정에 따라 자동으로 호출되는 엔트리 포인트
        public IActionResult Index()
        {
            var user = HttpContext.Session.GetString("UserAccount");
            var isAdmin = HttpContext.Session.GetString("IsAdmin");
            if (string.IsNullOrEmpty(user))
                return RedirectToAction("Login", "Account");

            ViewBag.User = user;
            ViewBag.IsAdmin = isAdmin == "true";

            return View();
        }
    }
}
