using System.Collections.ObjectModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using S.BL.DTOs.AtractionDTOs;
using S.BL.Services.Abstractions;
using S.Core.Models;

namespace S.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AtractionController : Controller
    {
        private readonly IAtractionService _atractionService;

        public AtractionController(IAtractionService atractionService)
        {
            _atractionService = atractionService;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                ICollection<AtractionUpdateDTO> atraction = await _atractionService.GetAllAsync();
                return View(atraction);
            }
            catch (Exception ex)
            {
                throw new Exception("Something went wrong");

            }
           
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create( AtractionCreateDTO atractionCreate)
        {
            try
            {
                ViewBag.Categories = new SelectList("CategoryId", "Name");
                await _atractionService.CreateAsync(atractionCreate);
                return RedirectToAction(nameof(Create));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
         
        }
    }
}
