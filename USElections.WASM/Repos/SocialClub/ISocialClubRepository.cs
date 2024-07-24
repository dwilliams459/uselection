using USElections.Shared.DTOs;

namespace USElections.WASM.Repository.SocialClub
{
    public interface ISocialClubRepository
    {
        public Task<IEnumerable<EventDTO>> GetSocialClubEvents();
    }
}
