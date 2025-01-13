using Microsoft.AspNetCore.Mvc;

namespace Simple.MVC.Controllers;

public class ContactUsController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
