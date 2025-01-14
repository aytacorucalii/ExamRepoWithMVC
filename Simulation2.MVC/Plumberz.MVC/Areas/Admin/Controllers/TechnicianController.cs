using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Plumberz.BL.DTOs.TechnicianDTOs;
using Plumberz.BL.Services.Abstractions;
using Plumberz.Core.Models;

namespace Plumberz.MVC.Areas.Admin.Controllers;
[Area("Admin")]
public class TechnicianController : Controller
{
    private readonly ITechnicianService _technicianService;
    readonly IMapper _mapper;
    public TechnicianController(ITechnicianService technicianService, IMapper mapper)
    {
        _technicianService = technicianService;
        _mapper = mapper;
    }

    public async Task<IActionResult> Index()
    {
        try
        {
            List<Technician> items = await _technicianService.GetAllAsync();
            return View(items);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
       
    }
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(TechnicianDTO createDto)
    {
        if (!ModelState.IsValid)
        {
            return StatusCode(StatusCodes.Status400BadRequest, ModelState);
        };
        return StatusCode(StatusCodes.Status201Created, await _technicianService.CreateAsync(createDto));
    }
    

    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            return StatusCode(StatusCodes.Status200OK, await _technicianService.SoftDelete(id));
        }
        catch (Exception e)
        {

            return StatusCode(StatusCodes.Status400BadRequest, e.Message);
        }
    }
   

    public async Task<IActionResult> Update(int id, TechnicianDTO createDto)
    {
        if (!ModelState.IsValid)
        {
            return StatusCode(StatusCodes.Status400BadRequest, ModelState);
        }
        try
        {
            return StatusCode(StatusCodes.Status200OK, await _technicianService.Update(id, createDto));
        }
        catch (Exception e)
        {

            return StatusCode(StatusCodes.Status400BadRequest, e.Message);
        }
    }
   
}
