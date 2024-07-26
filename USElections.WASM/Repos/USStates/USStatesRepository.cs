using System.Net.Http.Json;
using USElections.Shared.DTOs;

namespace USElections.WASM.Repos.USStates
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

        public async Task<List<USStateDTO>> GetUSStates()
        {
            try
            {
                var states = await _client.GetFromJsonAsync<List<USStateDTO>>("usstates") ?? new List<USStateDTO>();
                return states;
            }
            catch (Exception ex)
            {
                throw;
            }            
        }



    }
}
