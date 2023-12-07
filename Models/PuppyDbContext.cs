using Microsoft.EntityFrameworkCore;
namespace Puppy.Models
{
	public class PuppyDbContext : DbContext
	{
		public PuppyDbContext (DbContextOptions<PuppyDbContext> options)
			: base(options)
		{
		}
		public DbSet<Puppy> Puppy {get; set;} = default!;
		public DbSet<Client> Client {get;set;} = default!;
	}
}
