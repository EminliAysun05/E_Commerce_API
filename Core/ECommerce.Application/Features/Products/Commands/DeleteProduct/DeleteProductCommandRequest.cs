using ECommerce.Application.Repositories.UnitOfWorks;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Application.Features.Products.Commands.DeleteProduct
{
	public class DeleteProductCommandRequest : IRequestHandler<DeleteCommandProductRequest>
	{
		private readonly IUnitOfWork _unitOfWork;

		public DeleteProductCommandRequest(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}

		public async Task<Unit> Handle(DeleteCommandProductRequest request, CancellationToken cancellationToken)
		{
			var product = await _unitOfWork.GetReadRepoitory<Domain.Entities.Product>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);
			product.IsDeleted = true;

			await _unitOfWork.GetWriteRepository<Domain.Entities.Product>().UpdateAsync(product);
			await _unitOfWork.SaveAsync();
			return Unit.Value;
		}
	}
}
