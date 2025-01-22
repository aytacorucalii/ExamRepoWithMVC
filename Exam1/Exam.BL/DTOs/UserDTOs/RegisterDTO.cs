using FluentValidation;
using System.ComponentModel.DataAnnotations;

namespace Exam.BL.DTOs;

public class RegisterDTO
{
    [Required]
    [Display(Prompt = "Username")]
    public string UserName { get; set; }
    [Display(Prompt = "Email")]
    [Required]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; }

    [Display(Prompt = "Password")]
    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }
    [Required]
    [DataType(DataType.Password)]
    public string ConfirmPassword { get; set; }
    [Required]
    [Display(Prompt = "RememberMe")]
    public bool RememberMe { get; set; }
}
public class RegisterDTOValidation : AbstractValidator<RegisterDTO>
{
    public RegisterDTOValidation()
    {
        RuleFor(x => x.UserName)
            .NotEmpty().WithMessage("Please enter UserName")
            .MaximumLength(15).WithMessage("Maximum charter length are 15")
            .MinimumLength(4).WithMessage("Minimum charter length are 4");
        RuleFor(x => x.Email)
           .NotEmpty().WithMessage("Please enter email")
           .MaximumLength(50).WithMessage("Maximum charter length are 50")
           .MinimumLength(10).WithMessage("Minimum charter length are 10")
           .EmailAddress().WithMessage("Please enter correct email");
        RuleFor(x => x.Password)
            .NotEmpty().WithMessage("Please enter Password")
            .MinimumLength(4).WithMessage("Minimum charter length are 4");
        RuleFor(x => x.ConfirmPassword)
           .NotEmpty().WithMessage("Please enter Password")
           .MinimumLength(4).WithMessage("Minimum charter length are 4")
           .Equal(x=>x.Password).WithMessage("Confirm password is wrong!");
    }
}
