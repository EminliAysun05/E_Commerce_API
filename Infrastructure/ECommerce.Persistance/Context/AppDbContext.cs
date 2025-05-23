﻿using ECommerce.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Persistance.Context
{
	public class AppDbContext : IdentityDbContext<User, UserRole, Guid>
	{
		public AppDbContext() { }

		public AppDbContext(DbContextOptions options) : base(options)
		{

		}

		public DbSet<Brand> Brands { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Detail> Details { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<ProductCategory> ProductCategories { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
		}
	}
}
