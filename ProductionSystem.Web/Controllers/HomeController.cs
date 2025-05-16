using Microsoft.AspNetCore.Mvc;

namespace ProductionSystem.Web.Controllers
{
    public class HomeController : Controller
    {
        //����� ������ ���� �ڵ����� ȣ��Ǵ� ��Ʈ�� ����Ʈ
        public IActionResult Index()
        {
            var user = HttpContext.Session.GetString("UserAccount");
            if (string.IsNullOrEmpty(user))
                return RedirectToAction("Login", "Account");

            ViewBag.User = user;
            ViewBag.UserName = HttpContext.Session.GetString("UserName");
            ViewBag.IsAdmin = HttpContext.Session.GetString("IsAdmin") == "1" ? true : false;

            return View();
        }
    }
}
