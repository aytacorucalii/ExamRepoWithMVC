using Microsoft.AspNetCore.Mvc;
using Simple.BL.DTOs.Cart;
using Simple.BL.Services.Abstractions;
using Simple.Core.Models;

namespace Simple.MVC.Areas.Admin.Controllers;

[Area("Admin")]
public class WhyUsController : Controller
{
    private readonly ICartItemService _cartItemService;

    public WhyUsController(ICartItemService cartItemService)
    {
        _cartItemService = cartItemService;
    }

    public IActionResult Index()
    {
        return View();
    }
    public async Task<IActionResult> Create(CartDTO entityDTO)
    {
        if (!ModelState.IsValid)
        {
            return StatusCode(StatusCodes.Status404NotFound);
        };
        return StatusCode(StatusCodes.Status201Created, await _cartItemService.CreateAsync(entityDTO));
    }
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            return StatusCode(StatusCodes.Status201Created, await _cartItemService.SoftDeleteAsync(id));
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status400BadRequest, ex);
        }
    }
    public async Task<IActionResult> Update(int id, CartDTO entityDTO)
    {
        if (!ModelState.IsValid)
        {
            return StatusCode(StatusCodes.Status404NotFound);
        }
        try
        {
            return StatusCode(StatusCodes.Status201Created, await _cartItemService.SoftDeleteAsync(id));
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status400BadRequest, ex);
        }
    }
}