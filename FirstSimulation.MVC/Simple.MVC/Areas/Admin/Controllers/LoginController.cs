using Microsoft.AspNetCore.Mvc;

namespace Simple.MVC.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
