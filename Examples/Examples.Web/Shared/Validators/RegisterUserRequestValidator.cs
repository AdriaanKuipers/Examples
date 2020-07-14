using Examples.Web.Shared.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.Web.Shared.Validators
{
    public class RegisterUserRequestValidator : AbstractValidator<RegisterUserRequest>
    {
        public RegisterUserRequestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name must not be empty");
            RuleFor(x => x.Name).MaximumLength(50).WithMessage("Name may not be longer than 50 characters");
            RuleFor(x => x.Age).InclusiveBetween(18, 50).WithMessage("Age must be between 18 and 50");
        }
    }
}
