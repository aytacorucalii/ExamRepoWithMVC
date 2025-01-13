using Microsoft.AspNetCore.Mvc;

namespace Simple.MVC.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
