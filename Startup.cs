using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ImageService
{
	public class Startup
	{
		readonly IConfiguration _config;
		public Startup(IConfiguration config) => _config = config;
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddControllers();
		}
		public void Configure(IApplicationBuilder app)
		{
			app.UseRouting();
			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}
}
