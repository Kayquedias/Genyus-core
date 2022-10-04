using teste01.Model;

namespace teste01.Repositories
{
  public class ClientRepository : IClientRepository
  {
    public readonly ClientContext _context;

    public ClientRepository(ClientContext context) {
        _context = context;
    }

    public async Task<Client> Create(Client client)
    {
      _context.Clients.Add(client);
      await _context.SaveChangesAsync();

      return client;
    }

    public Task Delete(int Id)
    {
      throw new NotImplementedException();
    }

    public Task<IEnumerable<Client>> Get()
    {
      throw new NotImplementedException();
    }

    public Task<Client> Get(int Id)
    {
      throw new NotImplementedException();
    }

    public Task Update(Client client)
    {
      throw new NotImplementedException();
    }
  }
}