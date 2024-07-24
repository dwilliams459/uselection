using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USElections.Shared.DTOs
{
    public class TeamDetailsDTO
    {
        public int RowId { get; set; }
        public int TeamId { get; set; }

        public int WeekNumber { get; set; }
        public string Day { get; set; }

        public DateTime? GameDate { get; set; }

        public DateTime? GameTime { get; set; }

        public string Opponenet { get; set; }

        public int TeamScore { get; set; }

        public int OpponentScore { get; set; }

        public int Offense1stDown { get; set; }

        public int OffenseTotalYards { get; set; }

        public int OffensePassYards { get; set; }

        public int OffenseRushYards { get; set; }

        public int OffenseTurnover { get; set; }

        public int Defense1stDown { get; set; }

        public int DefenseTotalYards { get; set; }

        public int DefensePassYards { get; set; }

        public int DefenseRushYards { get; set; }

        public int DefenseTurnover { get; set; }
        public decimal ExpectedOffense { get; set; }

        public decimal ExpectedDefense { get; set; }

        public decimal ExpectedSpecialTeams { get; set; }
    }
}
