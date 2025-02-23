using Bogus;
using ECommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Persistance.Configuration
{
	public class ProductConfiguration : IEntityTypeConfiguration<Product>
	{
		public void Configure(EntityTypeBuilder<Product> builder)
		{
			Faker faker = new Faker();

			Product product1 = new()
			{
				Id = 1,
				Title = faker.Commerce.ProductName(),
				Description = faker.Lorem.Sentence(10),
				BrandId = 1,
				Discount = (int)faker.Random.Decimal(0, 10),
				Price = (int)faker.Finance.Amount(10,1000),
				CreatedDate = DateTime.UtcNow,
				IsDeleted = false
			};

			Product product2 = new()
			{
				Id = 2,
				Title = faker.Commerce.ProductName(),
				Description = faker.Lorem.Sentence(10),
				BrandId = 3,
				Discount = (int)faker.Random.Decimal(0, 10),
				Price = (int)faker.Finance.Amount(10, 1000),
				CreatedDate = DateTime.UtcNow,
				IsDeleted = false
			};

			builder.HasData(product1, product2);
		}
	}
}
