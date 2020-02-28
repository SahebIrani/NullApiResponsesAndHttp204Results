using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.DependencyInjection;

namespace Demo
{
	public class Startup
	{
		public void ConfigureServices(IServiceCollection services) =>
			services.AddControllers(opt =>  //? or AddMvc()
			{
				//? remove formatter that turns nulls into 204 - No Content responses
				//? this formatter breaks Angular's Http response JSON parsing
				opt.OutputFormatters.RemoveType<HttpNoContentOutputFormatter>();
			});

		public void Configure(IApplicationBuilder app)
		{
			app.UseHttpsRedirection();

			app.UseRouting();

			app.UseEndpoints(endpoints => endpoints.MapControllers());
		}
	}
}
