using System.Net.Http.Json;
using USElections.Shared.DTOs;

namespace USElections.WASM.Repos
{
    public interface IUSStatesRepository
    {
        Task<List<USStateDTO>> GetUSStates();
    }

    public class USStatesRepository : IUSStatesRepository
    {
        private readonly HttpClient _client;

        public USStatesRepository(HttpClient client)
        {
            _client = client;   
        }

        public async Task<List<USStateDTO>> GetUSStates() => await _client.GetFromJsonAsync<List<USStateDTO>>("usstates/GetUSStates/");
    }
}
