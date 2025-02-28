using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace ECommerce.Application;

   public static class ECommerceApplicationRegistration
    {
        public static void AddApplication(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();

		services.AddMediatR(assembly);
		//services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(assembly));

	}
}
 