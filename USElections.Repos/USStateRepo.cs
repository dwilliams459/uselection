using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USElections.Data;
using USElections.Data.Models;
using USElections.Repos.Interfaces;
using USElections.Shared.DTOs;

namespace USElections.Repos
{
    public class USStateRepo : IUSStateRepo
    {
        private USElectionsDBContext _context;

        public USStateRepo(USElectionsDBContext context)
        {
            _context = context;
        }

        public async Task<List<USStateDTO>> GetUSStates()
        {
            var usStates = await _context.USStates.ToListAsync();

            var usStatesDTO = new List<USStateDTO>();
            usStates.ForEach(usState =>
            {
                usStatesDTO.Add(new USStateDTO
                {
                    GID = usState.GID,
                    Electors = usState.Electors,
                    IsTerritory = usState.IsTerritory,
                    Name = usState.Name,
                    Path = usState.Path,
                    PathSuffix = usState.PathSuffix,
                    PathType = usState.PathType,
                    RegionId = usState.RegionId,
                    RegionName = usState.RegionName,
                    StateId = usState.StateId,
                    TransformX = usState.TransformX,
                    TransformY = usState.TransformY
                });
            });

            return usStatesDTO;
        }
    }
}
