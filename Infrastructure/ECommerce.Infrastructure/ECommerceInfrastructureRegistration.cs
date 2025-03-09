using ECommerce.Infrastructure.Tokens;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Infrastructure;

public static class ECommerceInfrastructureRegistration
{
	public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
	{
		services.Configure<TokenSettings>(configuration.GetSection("JWT"));
		//services.AddSingleton<ITokenService, TokenService>();
	}
}
