using Microsoft.AspNetCore.Mvc;

namespace Test.MVC.Controllers;

public class ContactController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
