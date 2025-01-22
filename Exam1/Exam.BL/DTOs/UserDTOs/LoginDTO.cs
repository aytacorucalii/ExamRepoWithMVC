using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.BL.DTOs;

public class LoginDTO
{
    [Required]
    [Display(Prompt ="Username")]
    public string UserName { get; set; }
    [Display(Prompt = "Password")]
    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }
    [Required]
    [Display(Prompt = "RememberMe")]
    public bool RememberMe { get; set; }
}
public class LoginDTOValidation : AbstractValidator<LoginDTO>
{
    public LoginDTOValidation()
    {
        RuleFor(x => x.UserName)
            .NotEmpty().WithMessage("Please enter UserName")
            .MaximumLength(15).WithMessage("Maximum charter length are 15")
            .MinimumLength(4).WithMessage("Minimum charter length are 4");
        RuleFor(x => x.Password)
           .NotEmpty().WithMessage("Please enter Password")
           .MinimumLength(4).WithMessage("Minimum charter length are 4");
    }
}
