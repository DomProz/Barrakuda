using Application.Models;
using FluentValidation;

namespace Application.Validators
{
    public class LoginDtoValidator : AbstractValidator<LoginDto>
    {
        public LoginDtoValidator()
        {
            RuleFor(x => x.Email)
                  .NotEmpty()
                  .EmailAddress();
        }
    }
}
