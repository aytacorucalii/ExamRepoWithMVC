using Microsoft.AspNetCore.Mvc;

namespace Simple.MVC.Controllers;

public class QuestionController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
