using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ImageService.Models;

namespace ImageService.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class ImageController : ControllerBase
	{
		readonly ApplicationContext _app;
		public ImageController(ApplicationContext app) => _app = app;
		[HttpGet("{id}")]
		public async Task<ActionResult<Image>> GetAsync(int id)
		{
			return await _app.Images.FindAsync(id);
		}
	}
}
