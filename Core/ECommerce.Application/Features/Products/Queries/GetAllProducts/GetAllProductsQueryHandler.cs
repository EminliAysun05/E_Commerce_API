using ECommerce.Application.DTOs;
using ECommerce.Application.Repositories.UnitOfWorks;
using ECommerce.Domain.Entities;
using ECommerce.Application.Interfaces.AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Product = ECommerce.Domain.Entities.Product;

namespace ECommerce.Application.Features.Products.Queries.GetAllProducts;

public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQueryRequest, IList<GetAllProductsQueryResponse>>
{
    private readonly IUnitOfWork unitOfWork;
    public readonly IMapper mapper;

    public GetAllProductsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }



    public async Task<IList<GetAllProductsQueryResponse>> Handle(GetAllProductsQueryRequest request, CancellationToken cancellationToken)
    {
        var products = await unitOfWork.GetReadRepoitory<Product>().GetAllAsync(include: x => x.Include(b => b.Brand));
        Product a = new();
        var brand = mapper.Map<BrandDto, Brand>(new Brand());
        //List<GetAllProductsQueryResponse> response = new();
        //foreach (var product in products)
        //{
        //	response.Add(new GetAllProductsQueryResponse
        //	{
        //		Title = product.Title,
        //		Description = product.Description,
        //		Discount = product.Discount,
        //		Price = product.Price - (product.Price*product.Discount/100)
        //	});
        //}

        var map = mapper.Map<GetAllProductsQueryResponse, Product>(products);
        foreach (var item in map)
            item.Price = item.Price - item.Price * item.Discount / 100;

        return map;
        //throw new Exception("error mesaji");
    }
}
