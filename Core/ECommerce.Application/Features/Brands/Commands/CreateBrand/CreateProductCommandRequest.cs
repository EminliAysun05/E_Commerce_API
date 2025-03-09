using ECommerce.Application.Repositories.UnitOfWorks;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Application.Features.Brands.Commands.CreateBrand
{
	public class CreateProductCommandRequest : IRequestHandler<CreateBrandCommandResponse>
	{
		private readonly IUnitOfWork unitOfWork;

		public CreateProductCommandRequest(IUnitOfWork unitOfWork)
		{
			this.unitOfWork = unitOfWork;
		}

		public async Task<Unit> Handle(CreateBrandCommandResponse request, CancellationToken cancellationToken)
		{
			Domain.Entities.Brand brand = new Domain.Entities.Brand(request.Name);
			
			await unitOfWork.GetWriteRepository<Domain.Entities.Brand>().AddAsync(brand);

			await unitOfWork.SaveAsync();
			return Unit.Value;
		}
	}
}
