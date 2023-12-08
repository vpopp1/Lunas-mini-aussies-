using Microsoft.EntityFrameworkCore;
namespace Lunas_mini_aussies.Models
{
	public class PuppyDbContext : DbContext
	{
		public PuppyDbContext (DbContextOptions<PuppyDbContext> options)
			: base(options)
		{
		}
		public DbSet<Client> Client {get;set;} = default!;
		public DbSet<Puppy> Puppies {get; set;} = default!;
		

    }
}
