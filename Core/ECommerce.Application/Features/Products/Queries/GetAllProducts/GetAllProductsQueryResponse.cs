using ECommerce.Application.DTOs;
using ECommerce.Domain.Entities;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Application.Features.Products.Queries.GetAllProducts
{
    public class GetAllProductsQueryResponse
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Discount { get; set; }
        public BrandDto Brand { get; set; }
    }
}
