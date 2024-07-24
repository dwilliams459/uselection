using USElections.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USElections.Shared.SocialClub
{
    public class SocialClubPageData
    {
        public IEnumerable<EventDTO> Events { get; set; } = [];
    }
}
