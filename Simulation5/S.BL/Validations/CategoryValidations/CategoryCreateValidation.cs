using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using S.BL.DTOs.CategoryDTOs;

namespace S.BL.Validations.CategoryValidations
{
    public class CategoryCreateValidation:AbstractValidator<CategoryCreateDTO>
    {
        public CategoryCreateValidation()
        {
           
            RuleFor(x => x.Title).NotEmpty().WithMessage("Please enter Title");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Please enter Description");
            RuleFor(x => x.IsDeleted).NotEmpty().WithMessage("Category is deleted");
            RuleFor(x => x.Img).NotEmpty().WithMessage("Please enter image");
        }
    }
}
