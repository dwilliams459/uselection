using USElections.Data;
using USElections.Shared.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace USElections.Repos.Football
{
    public interface IfootballRepo
    {
        List<TeamDTO> GetTeamList();
        List<TeamDetailsDTO> GetTeamDetails(int teamID);
    }
    public class footballRepo : IfootballRepo
    {
        private readonly FootballdBContext _context;
        public footballRepo(FootballdBContext context)
        {
            _context = context;
        }

        public List<TeamDetailsDTO> GetTeamDetails(int teamID)
        {
            var query = (from detials in _context.TeamDetails.AsNoTracking()
                         where detials.TeamId == teamID
                         select new TeamDetailsDTO
                         {
                             RowId = detials.RowId,
                             TeamId = teamID,
                             WeekNumber = detials.WeekNumber,
                             Day = detials.Day,
                             GameDate = detials.GameDate,
                             GameTime = detials.GameTime,
                             Opponenet = detials.Opponenet,
                             TeamScore = detials.TeamScore,
                             OpponentScore = detials.OpponentScore,
                             Offense1stDown = detials.Offense1stDown,
                             OffensePassYards = detials.OffensePassYards,
                             OffenseRushYards = detials.OffenseRushYards,
                             OffenseTotalYards = detials.OffenseTotalYards,
                             OffenseTurnover = detials.OffenseTurnover,
                             Defense1stDown = detials.Defense1stDown,
                             DefensePassYards = detials.DefensePassYards,

                         }).ToList();
            return query;
        }

        public List<TeamDTO> GetTeamList()
        {
            var query =  (from team in _context.Team.AsNoTracking()
                         select new TeamDTO
                         {
                             TeamID = team.RowId,
                             TeamName = team.TeamName
                         }
                         );

            return  query.ToList();
                        
        }
    }
}
