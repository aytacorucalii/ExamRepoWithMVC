using FluentValidation;
using S.BL.DTOs.AtractionDTOs;

namespace S.BL.Validations.AtractionValidation
{
    public class AtractionUpdateValidation : AbstractValidator<AtractionUpdateDTO>
    {
        public AtractionUpdateValidation()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Please enter Id");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Please enter Title");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Please enter Description");
            RuleFor(x => x.CategoryId).NotEmpty().WithMessage("Please enter CategoryId");
            RuleFor(x => x.MaxPrice).NotEmpty().WithMessage("Please enter MaxPrice");
            RuleFor(x => x.MinPrice).NotEmpty().WithMessage("Please enter MinPrice");
        }
    }
}
