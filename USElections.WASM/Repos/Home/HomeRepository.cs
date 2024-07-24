using USElections.Shared.DTOs;
using USElections.WASM.Repository.Routes;
using USElections.WASM.Repository.SocialClub;
using System.Net.Http.Json;

namespace USElections.WASM.Repository.Home
{
    public class HomeRepository(HttpClient client) : IHomeRepository
    {
        private readonly HttpClient _client = client;

        public async Task<IEnumerable<EventDTO>> GetEvents()
        {
            return await _client.GetFromJsonAsync<IEnumerable<EventDTO>>(EventsEndpoints.Events) ?? [];
        }
    }
}
