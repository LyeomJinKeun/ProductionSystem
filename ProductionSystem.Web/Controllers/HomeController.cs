using Microsoft.AspNetCore.Mvc;

namespace ProductionSystem.Web.Controllers
{
    public class HomeController : Controller
    {
        //����� ������ ���� �ڵ����� ȣ��Ǵ� ��Ʈ�� ����Ʈ
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
