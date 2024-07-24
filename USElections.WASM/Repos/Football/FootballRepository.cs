using USElections.Shared.DTOs;
using System.Net.Http.Json;

namespace USElections.WASM.Repos.Football
{
    public interface IFootballRepository
    {
        Task<List<TeamDTO>> GetTeamList();
        Task<List<TeamDetailsDTO>> GetTeamDetailsList(string teamId);
    }
    public class FootballRepository : IFootballRepository
    {
        private readonly HttpClient _client;
        public FootballRepository(HttpClient client)
        {
            _client = client;
        }

        public async Task<List<TeamDetailsDTO>> GetTeamDetailsList(string teamId)
        {
            teamId = "01";
            return await _client.GetFromJsonAsync<List<TeamDetailsDTO>>("Football/GetTeamDetails/" + (teamId));
        }

        public async Task<List<TeamDTO>> GetTeamList()
        {
            
            return await _client.GetFromJsonAsync<List<TeamDTO>>("Football/GetTeams") ?? throw new Exception("GetActiveContractors - data cannot be null");
        }
    }
}
