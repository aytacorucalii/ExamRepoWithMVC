using Microsoft.AspNetCore.Mvc;
using Pr.BL.DTOs.DoctorDTOs;
using Pr.BL.Services.Concretes;

namespace Pr.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DoctorController : Controller
    {
        private readonly IDoctorService _doctorService;

        public DoctorController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }

        public async Task<IActionResult> Index()
        {
            await _doctorService.GetAllAsync();
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(DoctorCreateDTO doctorCreateDTO)
        {
            await _doctorService.CreateAsync(doctorCreateDTO);
            return RedirectToAction("Index");
        }
    }
}
