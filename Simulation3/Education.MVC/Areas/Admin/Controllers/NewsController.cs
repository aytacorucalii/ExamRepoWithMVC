using Education.BL.DTOs.NewsDTOs;
using Education.BL.Services.Abstractions;
using Education.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Education.MVC.Areas.Admin.Controllers;
[Area("Admin")]

public class NewsController : Controller
{
    private readonly INewsService _newsService;

    public NewsController(INewsService newsService)
    {
        _newsService = newsService;
    }

    public async Task<IActionResult> Index()
    {
        try
        {
            ICollection<News> news = await _newsService.GetAllAsync();
            return View(news);
        }
        catch (Exception ex) 
        {
            return BadRequest(ex);
        }
       

    }
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(NewsCreateDTO newsCreateDTO)
    {
        try
        {
            await _newsService.CreateAsync(newsCreateDTO);
            return RedirectToAction("Index");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
       
      
    }
    public async Task<IActionResult> Update(int id)
    {
       
        try
        {
            await _newsService.GetByIdAsync(id);
            return RedirectToAction("Index");
        }
        catch (Exception e)
        {

            return StatusCode(StatusCodes.Status400BadRequest, e.Message);
        }


    }
    [HttpPost]
    public async Task<IActionResult> Update(int id, NewsUpdateDTO newsDTO)
    {

        try
        {
            await _newsService.Update(id,newsDTO);
            return RedirectToAction("Index");
        }
        catch (Exception e)
        {

            return StatusCode(StatusCodes.Status400BadRequest, e.Message);
        }


    }
}
