using Microsoft.AspNetCore.Mvc;

namespace Exam1.MVC.Areas.Admin.Controllers;
[Area("Admin")]

public class CarController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
