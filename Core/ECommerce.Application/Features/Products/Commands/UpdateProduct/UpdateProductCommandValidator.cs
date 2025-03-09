using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Application.Features.Products.Commands.UpdateProduct
{
	public class UpdateProductCommandValidator : AbstractValidator<UpdateProductCommandRequest>
	{

		public UpdateProductCommandValidator()
		{

			RuleFor(p => p.Id)
				.GreaterThan(0);

			RuleFor(p => p.Title)
			   .NotEmpty().WithMessage("{PropertyName} is required.")
			   .NotNull()
			   .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");

			RuleFor(p => p.Description)
				.NotEmpty().WithMessage("{PropertyDescription} is required.");

			RuleFor(p => p.BrandId)
				.GreaterThan(0);

			RuleFor(p => p.Price)
				.GreaterThan(0);

			RuleFor(p => p.Discount)
				.GreaterThanOrEqualTo(0);

			RuleFor(p => p.CategoryIds)
				.Must(p => p.Count > 0).WithMessage("{PropertyName} is required.");
		}


	}
}
