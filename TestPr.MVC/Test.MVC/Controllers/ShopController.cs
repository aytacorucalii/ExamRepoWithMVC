using Microsoft.AspNetCore.Mvc;

namespace Test.MVC.Controllers;

public class ShopController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
