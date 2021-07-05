using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace ImageService.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class ImageController : ControllerBase
	{
		readonly IWebHostEnvironment _env;
		public ImageController(IWebHostEnvironment env)
		{
			_env = env;
		}
		[HttpGet]
		public IActionResult Get()
		{
			return Content(_env.EnvironmentName);
		}
	}
}
