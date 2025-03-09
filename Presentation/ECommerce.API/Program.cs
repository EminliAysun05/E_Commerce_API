using ECommerce.Persistance;
using ECommerce.Application;
using ECommerce.Mapper;
using ECommerce.Application.Interfaces.AutoMapper;
using ECommerce.Application.Exceptions;
using ECommerce;


namespace ECommerce.API
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.

			builder.Services.AddControllers();
			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();
		
			var env = builder.Environment;	

			builder.Configuration.SetBasePath(env.ContentRootPath)
				.AddJsonFile("appsettings.json", optional: false)
				.AddJsonFile($"appsettings{env.EnvironmentName}", optional: true);

			builder.Services.AddPersistance(builder.Configuration);
			builder.Services.AddApplication();
			builder.Services.AddMapper();
			builder.Services.AddTransient<ExceptionMiddleWare>();
		//	builder.Services.AddInfrastructure(builder.Configuration);
			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			//app.UseHttpsRedirection();
			app.ConfigureExceptionHandler();
			//app.UseMiddleware<ExceptionMiddleWare>();
			
			app.UseAuthorization();


			app.MapControllers();

			app.Run();
		}
	}
}
