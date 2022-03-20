using Application.Interfaces;
using Application.Models;
using FluentValidation;

namespace Application.Validators
{
    public class RegisterUserDtoValidator : AbstractValidator<RegisterUserDto>
    {
        public RegisterUserDtoValidator(IAccountService accountService)
        {
            RuleFor(x => x.Email)
                .NotEmpty()
                .EmailAddress();

            RuleFor(x => x.Password).MinimumLength(6);

            RuleFor(x => x.ConfirmPassword).Equal(x => x.Password);

            RuleFor(x => x.Email)
                .Custom((value, context) =>
                {
                    var isEmailIsTaken = accountService.IsMailIsTaken(value).Result;
                    if (isEmailIsTaken)
                        context.AddFailure(nameof(RegisterUserDto.Email), "That email is taken");
                });

            RuleFor(x => x.UserName)
                .Custom((value, context) =>
                {
                    var isUserNameIsTaken = accountService.IsUserNameIsTaken(value).Result;
                    if (isUserNameIsTaken)
                        context.AddFailure(nameof(RegisterUserDto.UserName), "That username is taken");
                });

        }
    }
}
