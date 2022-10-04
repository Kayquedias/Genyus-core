using Microsoft.EntityFrameworkCore;

namespace GenyusCore.Model
{
	public class ClientContext : DbContext
	{
		public ClientContext(DbContextOptions<ClientContext> options) : base(options) {
			Database.EnsureCreated();
		} 

		public DbSet<Client> Clients { get; set; }
	}
}