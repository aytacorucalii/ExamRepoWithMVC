using Microsoft.AspNetCore.Mvc;

namespace Simple.MVC.Controllers;

public class AboutController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
