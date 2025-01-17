using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using S.BL.DTOs.AtractionDTOs;
using S.Core.Models;

namespace S.BL.Validations.AtractionValidation
{
    public class AtractionValidation : AbstractValidator<AtractionCreateDTO>
    {
        public AtractionValidation()
        {
            RuleFor(x=>x.Title).NotEmpty().WithMessage("Please enter Title");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Please enter Description");
            RuleFor(x => x.CategoryId).NotEmpty().WithMessage("Please enter CategoryId");
            RuleFor(x => x.MaxPrice).NotEmpty().WithMessage("Please enter MaxPrice");
            RuleFor(x => x.MinPrice).NotEmpty().WithMessage("Please enter MinPrice");
        }
    }
}
