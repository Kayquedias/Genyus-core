using Microsoft.EntityFrameworkCore;

namespace teste01.Model
{
	public class ClientContext : DbContext
	{
		public ClientContext(DbContextOptions<ClientContext> options) : base(options) {
			Database.EnsureCreated();
		} 

		public DbSet<Client> Clients { get; set; }
	}
}