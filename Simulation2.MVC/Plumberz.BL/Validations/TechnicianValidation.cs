
using FluentValidation;
using Plumberz.BL.DTOs.TechnicianDTOs;

namespace Plumberz.BL.Validations;

public class TechnicianValidation : AbstractValidator<TechnicianDTO>
{
    public TechnicianValidation()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("Please specify a Name.");
        RuleFor(x => x.Surname).NotEmpty().WithMessage("Please specify a Surname.");
        RuleFor(x => x.Image).NotEmpty().WithMessage("Please insert an image.");
    }
}