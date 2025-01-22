
using Exam.BL.Services.Abstractions;
using Exam1.MVC.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Exam1.MVC.Controllers
{
    public class HomeController : Controller
    {
      readonly IPersonService _personService;
        readonly ICarService _carService;
        public HomeController(IPersonService personService, ICarService carService)
        {
            _personService = personService;
            _carService = carService;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                HomeVM vm = new HomeVM()
                {
                    Cars = await _carService.GetViewItemAsync(),
                    Persons = await _personService.GetViewItemAsync()
                };
                return View(vm);
            }
            catch (Exception)
            {

                return BadRequest("view model error");
            } 
          
        }

      
    }
}
