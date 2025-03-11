using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Application.Features.Auth.Command.Register
{
	public class RegisterCommandValidator : AbstractValidator<RegisterCommandRequest>
	{
        public RegisterCommandValidator()
        {
            RuleFor(x => x.Fullname)
                .NotEmpty()
                .MaximumLength(50)
                .MinimumLength(2)
                .WithMessage("Fullname is required");

            RuleFor(x => x.Email)
                .NotEmpty()
                .MaximumLength(60)
                .MinimumLength(8)
                .EmailAddress()
                .WithMessage("Email is required");
		}
    }
}
