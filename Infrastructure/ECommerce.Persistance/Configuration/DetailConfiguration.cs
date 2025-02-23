using Bogus;
using ECommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Persistance.Configuration
{
	public class DetailConfiguration : IEntityTypeConfiguration<Detail>
	{
		public void Configure(EntityTypeBuilder<Detail> builder)
		{
			Faker faker = new Faker();

			Detail detail1 = new()
			{
				Id = 1,
				Title = faker.Lorem.Sentence(1),
				Description = faker.Lorem.Sentence(5),
				CategoryId = 1,
				IsDeleted = false,
				CreatedDate = DateTime.UtcNow
			};

			Detail detail2 = new()
			{
				Id = 2,
				Title = faker.Lorem.Sentence(1),
				Description = faker.Lorem.Sentence(5),
				CategoryId = 2,
				IsDeleted = false,
				CreatedDate = DateTime.UtcNow
			};

			Detail detail3 = new()
			{
				Id = 3,
				Title = faker.Lorem.Sentence(1),
				Description = faker.Lorem.Sentence(5),
				CategoryId = 3,
				IsDeleted = false,
				CreatedDate = DateTime.UtcNow
			};

			builder.HasData(detail1, detail2, detail3);

		}
	}
}
