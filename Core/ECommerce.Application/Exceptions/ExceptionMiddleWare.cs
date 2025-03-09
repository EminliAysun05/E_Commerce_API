using FluentValidation;
using Microsoft.AspNetCore.Http;
using ECommerce.Application.Exceptions;
using SendGrid.Helpers.Errors.Model;
using System.Text.Json;



namespace ECommerce.Application.Exceptions
{
	public class ExceptionMiddleWare : IMiddleware
	{


		public async Task InvokeAsync(HttpContext httpContext, RequestDelegate next)
		{
			//Console.WriteLine("🚀 Exception Middleware İşləyir..."); // TEST
			try
			{
				await next(httpContext);
			}
			catch (Exception ex)
			{
				//Console.WriteLine($"Global Exception Middleware İşləyir: {ex.Message}");
				await HandleException(httpContext, ex);
			}
		}
		private static Task HandleException(HttpContext httpContext, Exception exception)
		{
			int statusCodes = GetStatusCode(exception);
			httpContext.Response.ContentType = "application/json";
			httpContext.Response.StatusCode = statusCodes;

			if (exception.GetType() == typeof(ValidationException))
			{
				return httpContext.Response.WriteAsync(new ExceptionModel
				{
					Errors = ((ValidationException)exception).Errors.Select(x => x.ErrorMessage),
					StatusCodes = StatusCodes.Status400BadRequest
				}.ToString());

			}

			List<string> errors = new()
			{
			 $"Xeta mesaji: { exception.Message}",
			// $" Aciqlamasi: {exception.InnerException?.ToString() ?? "no inner exception"}"
			};
			return httpContext.Response.WriteAsync(new ExceptionModel
			{
				Errors = errors,
				StatusCodes = statusCodes
			}.ToString());

		}

		private static int GetStatusCode(Exception exception) =>
		   exception switch
		   {
			   BadRequestException => StatusCodes.Status400BadRequest,
			   NotFoundException => StatusCodes.Status404NotFound,
			   _ => StatusCodes.Status500InternalServerError,
		   };


	}


}
