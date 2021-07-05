using Microsoft.EntityFrameworkCore;

namespace ImageService.Models
{
	public class ApplicationContext : DbContext
	{
		public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
		public DbSet<Image> Images { get; set; }
	}
}
