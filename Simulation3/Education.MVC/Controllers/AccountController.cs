using Microsoft.AspNetCore.Mvc;

namespace Education.MVC.Controllers;

public class AccountController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
