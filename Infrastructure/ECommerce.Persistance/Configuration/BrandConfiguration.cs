﻿using Bogus;
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
	public class BrandConfiguration : IEntityTypeConfiguration<Brand>
	{
		public void Configure(EntityTypeBuilder<Brand> builder)
		{
			builder.Property(x => x.Name).HasMaxLength(256);

			Faker faker = new Faker();
			Brand brand1 = new()
			{
				Id = 1,
				Name = faker.Commerce.Department(),
				CreatedDate = DateTime.UtcNow,
				IsDeleted = false
			};

			Brand brand2 = new()
			{
				Id = 2,
				Name = faker.Commerce.Department(),
				CreatedDate = DateTime.UtcNow,
				IsDeleted = false
			};

			Brand brand3 = new()
			{
				Id = 3,
				Name = faker.Commerce.Department(),
				CreatedDate = DateTime.UtcNow,
				IsDeleted = true
			};
			builder.HasData(brand1, brand2, brand3);
		}
	}
}
