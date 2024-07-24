using USElections.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USElections.Repos.Events
{
    public interface IEventsRepository
    {
        public Task<IEnumerable<EventDTO>> GetEventsAsync();
        public Task<IEnumerable<EventDTO>> GetSocialClubEventsAsync();
    }
}
