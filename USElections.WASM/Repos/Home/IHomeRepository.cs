using USElections.Shared.DTOs;

namespace USElections.WASM.Repository.Home
{
    public interface IHomeRepository
    {
        public Task<IEnumerable<EventDTO>> GetEvents();
    }
}
