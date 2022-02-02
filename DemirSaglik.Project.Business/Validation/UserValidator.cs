using System;
using DemirSaglik.Project.Entities;
using FluentValidation;

namespace DemirSaglik.Project.Business.Validation
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {

            User user = new User();



           

            RuleFor(x => x.Password).Matches("^\\d{4}$").WithMessage("Please Enter Only 4 Number.");

            RuleFor(x => x.Password).NotEmpty().WithMessage("Please enter the your password.");

            RuleFor(x => x.Password).Equal(user.Password).WithMessage("Wrong Password.");

            RuleFor(x => x.Name).NotEmpty().WithMessage("Please enter the your username.");

            RuleFor(x => x.Name).EmailAddress().WithMessage("please enter the email format.");

        }
    }
}
