using ECommerce.Application.Repositories.Interfaces.AutoMapper;
using ECommerce.Application.Repositories.UnitOfWorks;
using ECommerce.Domain.Entities;
using MediatR;

namespace ECommerce.Application.Features.Products.Commands.UpdateProduct;

public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommandRequest>
{
	private readonly IUnitOfWork unitOfWork;
	private readonly IMapper mapper;

	public UpdateProductCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
	{
		this.unitOfWork = unitOfWork;
		this.mapper = mapper;
	}

	public async Task<Unit> Handle(UpdateProductCommandRequest request, CancellationToken cancellationToken)
	{
		//find product
		var product = await unitOfWork.GetReadRepoitory<Domain.Entities.Product>()
			.GetAsync(x => x.Id == request.Id && !x.IsDeleted);

		//exception checking
		if (product == null)
			throw new Exception("Product not found."); 

		//current product
		mapper.Map<Domain.Entities.Product>(request);
		
		//check current product's categories
		var existingCategories = await unitOfWork.GetReadRepoitory<ProductCategory>()
			.GetAllAsync(x => x.ProductId == product.Id);

		// 4. Mövcud və yeni kateqoriyaları müqayisə et
		var categoriesToRemove = existingCategories.Where(c => !request.CategoryIds.Contains(c.CategoryId)).ToList();
		var categoriesToAdd = request.CategoryIds.Where(id => !existingCategories.Any(c => c.CategoryId == id)).ToList();

		// 5. Lazımsız kateqoriyaları sil
		if (categoriesToRemove.Any())
		{
			await unitOfWork.GetWriteRepository<ProductCategory>()
				.HardDeleteRangeAsync(categoriesToRemove);
		}

		// 6. Yeni kateqoriyaları əlavə et
		foreach (var categoryId in categoriesToAdd)
		{
			await unitOfWork.GetWriteRepository<ProductCategory>().AddAsync(new ProductCategory
			{
				ProductId = product.Id,
				CategoryId = categoryId
			});
		}

		// 7. Məhsulu yenilə
		await unitOfWork.GetWriteRepository<Domain.Entities.Product>().UpdateAsync(product);
		await unitOfWork.SaveAsync();

		return Unit.Value;
	}
}
	//private readonly IUnitOfWork _unitOfWork;
	//private readonly IMapper _mapper;

	//public UpdateProductCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
	//{
	//	_unitOfWork = unitOfWork;
	//	_mapper = mapper;
	//}

	//public async Task Handle(UpdateProductCommandRequest request, CancellationToken cancellationToken)
	//{
	//	//hemin mehsulu tapiram
	//	var product = await _unitOfWork.GetReadRepoitory<Domain.Entities.Product>()
	//	.GetAsync(x => x.Id == request.Id && !x.IsDeleted);

	//	//if (product == null)
	//	//	throw new NotFoundException("Product not found.");

	//	// Request məlumatlarını mövcud məhsula map et
	//	_mapper.Map<Domain.Entities.Product, UpdateProductCommandRequest>(request);

	//	// Məhsulun köhnə kateqoriyalarını tap
	//	var productCategories = await _unitOfWork.GetReadRepoitory<Domain.Entities.ProductCategory>()
	//		.GetAllAsync(x => x.ProductId == request.Id);

	//	if (productCategories.Any())
	//	{
	//		// Köhnə kateqoriyaları sil
	//		await _unitOfWork.GetWriteRepository<Domain.Entities.ProductCategory>()
	//			.HardDeleteRangeAsync(productCategories);

	//	}

	//          foreach (var categoryId in request.CategoryIds)
	//          {
	//		await _unitOfWork.GetWriteRepository<ProductCategory>().AddAsync(
	//			new() { CategoryId = categoryId, ProductId = product.Id });
	//          }

	//          // Məhsulu yenilə
	//          await _unitOfWork.GetWriteRepository<Domain.Entities.Product>().UpdateAsync(product);

	//	return Unit.Value;


	//}



