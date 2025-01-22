using Exam.BL.DTOs;
using Exam.BL.Exceptions;
using Exam.BL.Services.Abstractions;
using Exam.Core.Enum;
using Microsoft.AspNetCore.Mvc;

namespace Exam1.MVC.Areas.Admin.Controllers;
[Area("Admin")]

public class AccountController : Controller
{
    readonly IAccountService _accountService;

    public AccountController(IAccountService accountService)
    {
        _accountService = accountService;
    }

    public IActionResult login()
    {
        if (User.Identity is not null && User.Identity.IsAuthenticated)
            return Redirect(User.IsInRole(Roles.Admin.ToString()) ? "/Admin" : "/");
        return View();
    }
    [HttpPost]
    [AutoValidateAntiforgeryToken]
    public async Task<IActionResult> login(LoginDTO dto, string? returnUrl=null)
    {
        if(!ModelState.IsValid)
        {
            return View(dto);
        }
        try
        {
            await _accountService.LoginAsync(dto);
        }
        catch (BaseException ex)
        {
            ModelState.AddModelError("CustomError", ex.Message);
            return View(dto);
        }
        catch (Exception)
        {
            
                ModelState.AddModelError("CustomError", "Something went wrong!");
                return View(dto);
            
        }
        return Redirect(returnUrl ?? (User.IsInRole(Roles.Admin.ToString()) ? "/admin" : "/"));
    }

    public IActionResult Register()
    {
        if (User.Identity is not null && User.Identity.IsAuthenticated)
            return Redirect(User.IsInRole(Roles.Admin.ToString()) ? "/Admin" : "/");
        return View();
    }
    [HttpPost]
    [AutoValidateAntiforgeryToken]
    public async Task<IActionResult> Register(RegisterDTO dto)
    {
        if (!ModelState.IsValid)
        {
            return View(dto);
        }
        try
        {
            await _accountService.RegisterAsync(dto);
        }
        catch (BaseException ex)
        {
            ModelState.AddModelError("CustomError", ex.Message);
            return View(dto);
        }
        catch (Exception)
        {

            ModelState.AddModelError("CustomError", "Something went wrong!");
            return View(dto);

        }
        return Redirect("/admin/account/login");
    }
    public async Task<IActionResult> Logout()
    {

        try
        {
            await _accountService.Logout();
            return Redirect("/");
        }

        catch (Exception)
        {

            return BadRequest("fgdsffch");
          
        }
    
    }
}

