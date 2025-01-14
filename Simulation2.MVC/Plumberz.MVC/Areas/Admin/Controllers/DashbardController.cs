using Microsoft.AspNetCore.Mvc;

namespace Plumberz.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashbardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
