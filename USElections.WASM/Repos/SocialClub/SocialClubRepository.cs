using USElections.Shared.DTOs;
using USElections.WASM.Repository.Routes;
using System.Net.Http.Json;

namespace USElections.WASM.Repository.SocialClub
{
    public class SocialClubRepository(HttpClient client) : ISocialClubRepository
    {
        private readonly HttpClient _client = client;

        public async Task<IEnumerable<EventDTO>> GetSocialClubEvents()
        {
            return await _client.GetFromJsonAsync<IEnumerable<EventDTO>>(EventsEndpoints.SocialClubEvents) ?? [];
        }
    }
}
