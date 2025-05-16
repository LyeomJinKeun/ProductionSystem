using Microsoft.AspNetCore.Mvc;
using ProductionSystem.Web.Models;
using ProductionSystem.Web.Data;

[Route("Apps/SystemManager/[controller]")]
public class UserRegisterController : Controller
{
    private readonly AppDbContext _context;

    public UserRegisterController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Index()
    {
        ViewBag.Users = _context.Users.ToList();
        return View("Views/Apps/SystemManager/UserRegister.cshtml");
    }

    [HttpPost("Create")]
    public IActionResult Create(UserModel model)
    {
        if (!ModelState.IsValid)
        {
            ViewBag.Users = _context.Users.ToList();
            return View("Views/Apps/SystemManager/UserRegister.cshtml", model);
        }

        _context.Users.Add(model);
        _context.SaveChanges();
        TempData["Success"] = "사용자가 등록되었습니다.";
        return RedirectToAction("Index");
    }

    [HttpPost("Delete")]
    public IActionResult Delete(int id)
    {
        var user = _context.Users.Find(id);
        if (user != null)
        {
            _context.Users.Remove(user);
            _context.SaveChanges();
            TempData["Success"] = "사용자가 삭제되었습니다.";
        }

        return RedirectToAction("Index");
    }
}
