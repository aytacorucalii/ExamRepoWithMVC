using Exam.Core.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.BL.DTOs;

public class PersonCreateDTO
{
    public string Name { get; set; }
    public string SurName { get; set; }
    public string Position { get; set; }

}
public class PersonCreateDTOValidation : AbstractValidator<PersonCreateDTO>
{
    public PersonCreateDTOValidation()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Please enter name")
            .MaximumLength(25).WithMessage("Maximum charter length are 25")
            .MinimumLength(3).WithMessage("Minimum charter length are 3");
        RuleFor(x => x.SurName)
           .NotEmpty().WithMessage("Please enter name")
           .MaximumLength(55).WithMessage("Maximum charter length are 55")
           .MinimumLength(3).WithMessage("Minimum charter length are 3");
        RuleFor(x => x.Position)
           .NotEmpty().WithMessage("Please enter Position")
           .MinimumLength(2).WithMessage("Minimum charter length are 2");
    }
}
