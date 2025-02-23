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
	public class CategoryConfiguration : IEntityTypeConfiguration<Category>
	{
		public void Configure(EntityTypeBuilder<Category> builder)
		{
			Category category1 = new()
			{
				Id = 1,
				Name = "Electronics",
				Priorty = 1,
				ParentId = 0,
				IsDeleted = false,
				CreatedDate = DateTime.UtcNow
			};

			Category category2 = new()
			{
				Id = 2,
				Name = "Fashion",
				Priorty = 2,
				ParentId = 0,
				IsDeleted = false,
				CreatedDate = DateTime.UtcNow
			};

			Category parent1 = new()
			{
				Id = 3,
				Name = "Laptop",
				Priorty = 1,
				ParentId = 1,
				IsDeleted = false,
				CreatedDate = DateTime.UtcNow
			};

			Category parent2 = new()
			{
				Id = 4,
				Name = "Woman",
				Priorty = 1,
				ParentId = 2,
				IsDeleted = false,
				CreatedDate = DateTime.UtcNow
			};

			builder.HasData(category1, category2, parent1, parent2);
		}
	}
}
