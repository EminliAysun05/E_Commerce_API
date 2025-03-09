using ECommerce.Application.Features.Products.Rules;
using ECommerce.Application.Repositories.UnitOfWorks;
using ECommerce.Domain.Entities;
using MediatR;

namespace ECommerce.Application.Features.Products.Common.CreateProduct
{
	internal class CreateProductCommonHandler : IRequestHandler<CreateProductCommandRequest>
	{
		private readonly IUnitOfWork unitOfWork;
		private readonly ProductRules productRules;

		public CreateProductCommonHandler(IUnitOfWork unitOfWork, ProductRules productRules)
		{
			this.unitOfWork = unitOfWork;
			this.productRules = productRules;
		}

		public async Task<Unit> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
		{

			IList<Product> products = await unitOfWork.GetReadRepoitory<Product>().GetAllAsync();
			await productRules.ProductTitleMustBeUnique(products, request.Title);

			Product product = new Product(request.Title, request.Description,request.BrandId, request.Price, request.Discount);

			await unitOfWork.GetWriteRepository<Product>().AddAsync(product);

			if (await unitOfWork.SaveAsync() > 0)
				foreach (var categoryIds in request.CategoryIds)
					await unitOfWork.GetWriteRepository<ProductCategory>().AddAsync(new ProductCategory
					{
						ProductId = product.Id,
						CategoryId = categoryIds
					});

			await unitOfWork.SaveAsync();

			return Unit.Value;
	
		}
	}
}
