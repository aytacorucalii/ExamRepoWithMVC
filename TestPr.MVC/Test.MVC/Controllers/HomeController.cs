using Microsoft.AspNetCore.Mvc;
using Test.BL.ViewModels;
using Test.DAL.Contexts;

namespace Test.MVC.Controllers;

public class HomeController : Controller
{
   private readonly AppDbContext _appDbContext;

    public HomeController(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public ActionResult Index()
    {
        //IEnumerable<SliderItemVM> items= _appDbContext
        return View();
    }

}
