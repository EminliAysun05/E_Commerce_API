using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Application.Exceptions
{
	public static class ConfigureExceptionMiddleware
	{
		public static void ConfigureExceptionHandler(this IApplicationBuilder app)
		{
			app.UseMiddleware<ExceptionMiddleWare>();
		}
	}
}
