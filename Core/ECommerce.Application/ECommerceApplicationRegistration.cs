using ECommerce.Application.Exceptions;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using FluentValidation;
using ECommerce.Application.Beheviors;
using ECommerce.Application.Features.Products.Rules;
using ECommerce.Application.Bases;

namespace ECommerce.Application;

public static class ECommerceApplicationRegistration
    {
        public static void AddApplication(this IServiceCollection services)
        {
        var assembly = Assembly.GetExecutingAssembly();

        services.AddTransient<ExceptionMiddleWare>();
		
		services.AddMediatR(assembly);
		
		services.AddRulesFromAssemblyContaining(assembly, typeof(BaseRules));
		services.AddValidatorsFromAssembly(assembly);
		// IPipelineBehavior qeydiyyatı
		services.AddTransient(typeof(IPipelineBehavior<,>), typeof(FluentValidationBehevior<,>));
		


	}

	private static IServiceCollection AddRulesFromAssemblyContaining(this IServiceCollection services, Assembly assembly, Type type)
	{
		var ruleTypes = assembly.GetTypes().Where(x => x.IsClass && !x.IsAbstract && x.IsSubclassOf(typeof(BaseRules)));
		foreach (var ruleType in ruleTypes)
		{
			services.AddTransient(ruleType);
		}
		return services;
	}
}
 