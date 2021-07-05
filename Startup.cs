using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ImageService.Models;

namespace ImageService
{
	public class Startup
	{
		readonly IConfiguration _config;
		public Startup(IConfiguration config) => _config = config;
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddDbContext<ApplicationContext>(options =>
			{
				options.UseSqlServer(_config.GetConnectionString("DefaultConnection"));
			});
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
