using AutoMapper;
using Exam.BL.DTOs;
using Exam.BL.Exceptions;
using Exam.BL.Services.Abstractions;
using Exam.Core.Enum;
using Microsoft.AspNetCore.Identity;

namespace Exam.BL.Services.Concretes;

public class AccountService : IAccountService
{
    readonly UserManager<IdentityUser> _userManager;
    readonly SignInManager<IdentityUser> _signinmanager;
    readonly IMapper _mapper;
    public AccountService(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signinmanager, IMapper mapper)
    {
        _userManager = userManager;
        _signinmanager = signinmanager;
        _mapper = mapper;
    }


    public async Task LoginAsync(LoginDTO dto)
    {
        IdentityUser user = await _userManager.FindByNameAsync(dto.UserName) ?? throw new BaseException("Credentials are wrong!");
        SignInResult res = await _signinmanager.PasswordSignInAsync(user, dto.Password,dto.RememberMe, true);
        if (!res.Succeeded) throw new BaseException("Credential are wrong");
    }

    public async Task Logout()
    {
        await _signinmanager.SignOutAsync();
    }

    public async Task RegisterAsync(RegisterDTO dto)
    {
        if (await _userManager.FindByNameAsync(dto.UserName) is not null) throw new BaseException();
        if (await _userManager.FindByEmailAsync(dto.Email) is not null) throw new BaseException();
        IdentityUser user = _mapper.Map<IdentityUser>(dto);
        IdentityResult res = await _userManager.CreateAsync(user, dto.Password);
        if(!res.Succeeded) throw new BaseException();
        res = await _userManager.AddToRoleAsync(user,Roles.User.ToString());
        if (!res.Succeeded) throw new BaseException();
    }
}
