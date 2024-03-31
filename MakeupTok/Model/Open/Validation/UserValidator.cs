using FluentValidation;

namespace MakeupTok.Model.Open.Validation;

public class UserValidator : AbstractValidator<User>
{

    /// <summary>
    /// FluentValidation validator for the RilaResult object.
    /// </summary>
    public UserValidator()
    {
        RuleFor(procedure => procedure.Username).NotNull().NotEmpty().MinimumLength(3).MaximumLength(20);
        RuleFor(procedure => procedure.).NotNull().NotEmpty().MinimumLength(0).MaximumLength(200);
        RuleFor(procedure => procedure.Color).NotNull().NotEmpty();
    }

}
