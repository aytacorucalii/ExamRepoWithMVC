using FluentValidation;
using Simple.BL.DTOs.Cart;
namespace Simple.BL.Validations.CartValidation;

public class CreateCartValidation : AbstractValidator<CartDTO>
{
    public CreateCartValidation()
    {
        RuleFor(x => x.Title).NotEmpty().WithMessage("Please spesify a title");
        RuleFor(x => x.Description).NotEmpty().WithMessage("Please spesify a message");
        RuleFor(x => x.Image).NotEmpty().WithMessage("Please spesify a message");

    }
}
