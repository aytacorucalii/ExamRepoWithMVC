using FluentValidation;
using Microsoft.AspNetCore.Http;

namespace Exam.BL.DTOs;

public class CarUpdateDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string ImgUrl { get; set; }
    public IFormFile Img { get; set; }
    public float RountCount { get; set; }
    public int Personİd { get; set; }
}
public class CarUpdateDTOValidation : AbstractValidator<CarUpdateDTO>
{
    public CarUpdateDTOValidation()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Please enter name")
            .MaximumLength(25).WithMessage("Maximum charter length are 25")
            .MinimumLength(3).WithMessage("Minimum charter length are 3");
        RuleFor(x => x.Price)
           .NotEmpty().WithMessage("Please enter name")
           .GreaterThan(1000).WithMessage("minimum 1000 azn");
        RuleFor(x => x.RountCount)
           .GreaterThan(999999999999).WithMessage("Please enter right Round");

        RuleFor(e => e.Personİd)
           .NotEmpty().WithMessage("Category id cannot be empty!")
           .GreaterThan(0).WithMessage("Category id must be a natural number!");
    }
}

