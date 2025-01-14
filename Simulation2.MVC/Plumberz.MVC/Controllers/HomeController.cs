using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Plumberz.MVC.Models;

namespace Plumberz.MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
