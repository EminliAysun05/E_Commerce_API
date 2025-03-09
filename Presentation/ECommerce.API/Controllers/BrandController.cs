using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class BrandController : ControllerBase
	{
		private readonly IMediator mediator;

		public BrandController(IMediator mediator)
		{
			this.mediator = mediator;
		}

	}
}
