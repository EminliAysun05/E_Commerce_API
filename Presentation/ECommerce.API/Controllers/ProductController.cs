using ECommerce.Application.Features.Products.Common.CreateProduct;
using ECommerce.Application.Features.Products.Commands.DeleteProduct;
using ECommerce.Application.Features.Products.Commands.UpdateProduct;
using ECommerce.Application.Features.Queries.GetAllProducts;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
        private readonly IMediator mediator;
        public ProductController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var response = await mediator.Send(new GetAllProductsQueryRequest());
            return Ok(response);

        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductCommandRequest request)
		{
			await mediator.Send(request);
			return Ok();
		}

        [HttpPost]
        public async Task<IActionResult> UpdateProduct (UpdateProductCommandRequest request)
        {
            await mediator.Send(request);
            return Ok();
		}

        [HttpPost]
        public async Task<IActionResult> DeleteProduct(DeleteCommandProductRequest request)
		{
			await mediator.Send(request);
			return Ok();
		}
	}
}
