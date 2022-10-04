using GenyusCore.Repositories;
using GenyusCore.Model;
using Microsoft.AspNetCore.Mvc;

namespace GenyusCore.Controllers
{
	[Route("api/[controller]")]
  [ApiController]
	public class ClientController : ControllerBase
	{
		private readonly IClientRepository _clientRepository;
		public ClientController(IClientRepository clientRepository) {
			_clientRepository = clientRepository;
		}
		[HttpGet]
		public async Task<IEnumerable<Client>> GetClients() {
			return await _clientRepository.Get();
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<Client>> GetClients(int id) {
			return await _clientRepository.Get(id);
		}

		[HttpPost]
		public async Task<ActionResult<Client>> PostClient([FromBody] Client client) {
			var newClient = await _clientRepository.Create(client);
			return client;
		}

		[HttpDelete("{ id }")]
		public async Task<ActionResult> DeleteClient(int id) {
			var clientToDelete = _clientRepository.Get(id);
			if (clientToDelete == null) 
				return NotFound();

			await _clientRepository.Delete(clientToDelete.Id);
			return NoContent();
		}

		[HttpPut]
		public async Task<ActionResult> PutClient(int id, Client client) {
			if(id != client.Id)
				return BadRequest();

			await _clientRepository.Update(client);
			return NoContent();
		}
	}

}