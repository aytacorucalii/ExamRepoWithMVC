using Microsoft.AspNetCore.Mvc;

namespace Test.MVC.Controllers;

public class QualityController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
