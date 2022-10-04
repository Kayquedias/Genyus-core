using teste01.Model;

namespace teste01.Repositories
{
	public interface IClientRepository
	{
		Task<IEnumerable<Client>> Get();
		Task<Client> Get(int Id);
		Task<Client> Create(Client client);
		Task Update(Client client);
		Task Delete(int Id);
	}
}