using ECommerce.Application.Exceptions;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using FluentValidation;
using ECommerce.Application.Beheviors;

namespace ECommerce.Application;

public static class ECommerceApplicationRegistration
    {
        public static void AddApplication(this IServiceCollection services)
        {
        var assembly = Assembly.GetExecutingAssembly();

        services.AddTransient<ExceptionMiddleWare>();

		services.AddMediatR(assembly);
		
		// services.AddValidatorsFromAssembly(assembly);
		//	services.AddFluentValidationAutoValidation();
		//.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
		//services.AddValidatorsFromAssembly(assembly);  // Bu metodu istifadə edin
		services.AddValidatorsFromAssembly(assembly);
		// IPipelineBehavior qeydiyyatı
		services.AddTransient(typeof(IPipelineBehavior<,>), typeof(FluentValidationBehevior<,>));
		//services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(assembly));
		//services.AddTransient(typeof(IPipelineBehavior<,>), typeof(FluentValidationBehevior<,>));

	}
}
 