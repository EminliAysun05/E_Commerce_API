using ECommerce.Application.Repositories.Interfaces;
using ECommerce.Application.Repositories.UnitOfWorks;
using ECommerce.Persistance.Context;
using ECommerce.Persistance.Repostories;
using ECommerce.Persistance.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Persistance;

public static class ECommercePersistenceRegistration
{
	public static void AddPersistance(this IServiceCollection services, IConfiguration configuration)
	{
		services.AddDbContext<AppDbContext>(opt =>
			opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

		services.AddScoped(typeof(IReadRepository<>), typeof(ReadRepository<>));
		services.AddScoped(typeof(IWriteRepository<>), typeof(WriteRepository<>));
		services.AddScoped<IUnitOfWork, UnitOfWork>();
	}
}
