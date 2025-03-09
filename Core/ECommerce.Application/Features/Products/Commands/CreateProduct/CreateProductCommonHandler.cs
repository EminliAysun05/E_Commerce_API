using ECommerce.Application.Repositories.UnitOfWorks;
using ECommerce.Domain.Entities;
using MediatR;

namespace ECommerce.Application.Features.Products.Common.CreateProduct
{
	internal class CreateProductCommonHandler : IRequestHandler<CreateProductCommandRequest>
	{
		private readonly IUnitOfWork unitOfWork;

		public CreateProductCommonHandler(IUnitOfWork unitOfWork)
		{
			this.unitOfWork = unitOfWork;
		}

		public async Task<Unit> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
		{
			Domain.Entities.Product product = new Product(request.Title, request.Description,request.BrandId, request.Price, request.Discount);

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
