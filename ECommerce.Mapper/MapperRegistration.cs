
using ECommerce.Application.Interfaces.AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Mapper;

    public static class MapperRegistration
    {
        public static void AddMapper(this IServiceCollection services)
	{
		services.AddSingleton<IMapper, AutoMapper.Mapper>();
	}
}
