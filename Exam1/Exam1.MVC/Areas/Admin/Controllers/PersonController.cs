using Exam.BL.DTOs;
using Exam.BL.Exceptions;
using Exam.BL.Services.Abstractions;
using Humanizer;
using Microsoft.AspNetCore.Mvc;

namespace Exam1.MVC.Areas.Admin.Controllers;
[Area("Admin")]

public class PersonController : Controller
{
    readonly IPersonService _personService;

    public PersonController(IPersonService personService)
    {
        _personService = personService;
    }
    public async Task<IActionResult> Index()
    {
        
        IEnumerable<PersonListItemDTO> list = await _personService.GetPersonListItemAsync();
            return View(list);
    }

    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    [AutoValidateAntiforgeryToken]
    public async Task<IActionResult> Create(PersonCreateDTO dto)
    {
        if (ModelState.IsValid)
        {
            return View (dto);
        }
        try
        {
            await _personService.CreateAsync(dto);
            await _personService.SaveChangesAsync();
            return Redirect("Index");

        }
        catch (BaseException ex)
        {
            ModelState.AddModelError("CustomError", ex.Message);
            return View(dto);
            
        }
        catch (Exception)
        {
            ModelState.AddModelError("CustomError", "Shnjkdenhckjhndk");
            return View(dto);

        }
    }
    public async Task<IActionResult> Update(int id)
    {
        try
        {
            return View(await _personService.GetByIdForUpdateAsync(id));
        }
        catch (BaseException ex)
        {
           return BadRequest(ex.Message);
        }
        catch (Exception)
        {
            return BadRequest("jjhendj");
        }
    }
    [HttpPost]
    [AutoValidateAntiforgeryToken]
    public async Task<IActionResult> Update(PersonUpdateDTO dto)
    {
        if (ModelState.IsValid)
        {
            return View(dto);
        }
        try
        {
            await _personService.UpdateAsync(dto);
            await _personService.SaveChangesAsync();
            return Redirect("Index");

        }
        catch (BaseException ex)
        {
            ModelState.AddModelError("CustomError", ex.Message);
            return View(dto);

        }
        catch (Exception)
        {
            ModelState.AddModelError("CustomError", "Shnjkdenhckjhndk");
            return View(dto);

        }
    }
    public async Task<IActionResult> Delete(int id)
    {
        
        try
        {
            await _personService.DeleteAsync(id);
            await _personService.SaveChangesAsync();
            return Redirect("Index");

        }
        catch (BaseException ex)
        {
            return BadRequest("jjhnhfs");

        }
        catch (Exception)
        {
            return BadRequest("ejkwnhkj");

        }
    }
    public async Task<IActionResult> Details(int id)
    {

        try
        {
            
            return View(await _personService.GetByIdWithChildAsync(id));

        }
        catch (BaseException ex)
        {
            return BadRequest(ex.Message);

        }
        catch (Exception)
        {
            return BadRequest("ejkwnhkj");

        }
    }
}
