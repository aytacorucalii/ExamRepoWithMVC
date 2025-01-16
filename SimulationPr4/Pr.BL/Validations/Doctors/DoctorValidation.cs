using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Pr.Core.Models;

namespace Pr.BL.Validations.Doctors
{
    public class DoctorValidation: AbstractValidator<Doctor>
    {
        public DoctorValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("please enter a Name");
            RuleFor(x => x.SurName).NotEmpty().WithMessage("please enter a SurName");
            RuleFor(f => f.ImgURL).NotNull().WithMessage("Please Attach your photo"); 
        }
    }
}
