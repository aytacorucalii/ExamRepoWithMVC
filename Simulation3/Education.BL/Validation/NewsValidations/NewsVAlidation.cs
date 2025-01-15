
using Education.BL.DTOs.NewsDTOs;
using FluentValidation;

namespace Education.BL.Validation.NewsValidations
{
    public class NewsVAlidation: AbstractValidator<NewsCreateDTO>
    {
        public NewsVAlidation()
        {
           
            RuleFor(x => x.Title).NotEmpty().WithMessage("please enter a Title");
            RuleFor(x => x.Description).NotEmpty().WithMessage("please enter a Title");
        }

    }
}
