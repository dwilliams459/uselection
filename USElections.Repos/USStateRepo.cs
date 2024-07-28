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
            //var usStates = await _context.USStates.Include(s => s.StateBullets).ToListAsync();
            var usStates = from state in _context.USStates
                           join bullet in _context.StateBullets on state.GID equals bullet.GID into ps
                           from bullet in ps.DefaultIfEmpty()
                           select new { state, bullet };

            var usStatesDTO = new List<USStateDTO>();
            usStates.ToList().ForEach(usState =>
            {
                usStatesDTO.Add(new USStateDTO
                {
                    GID = usState.state.GID,
                    Name = usState.state.Name,
                    Fill = usState.state.Fill,
                    Electors = usState.state.Electors,
                    Stroke = usState.state.Stroke,
                    Path = usState.state.Path,
                    Class = usState.state.Class,
                    Opacity = usState.state.Opacity,
                    StrokeOpacity = usState.state.StrokeOpacity,
                    StrokeWidth = usState.state.StrokeWidth,
                    StrokeLinejoin = usState.state.StrokeLinejoin,
                    Transform = usState.state.Transform,
                    Style = usState.state.Style,
                    FillOpacity = usState.state.FillOpacity,

                    LabelX = usState.bullet?.LabelX, 
                    LabelY = usState.bullet?.LabelY,
                    TextX =  usState.bullet?.TextX,
                    TextY =  usState.bullet?.TextY
                });
            });

            return usStatesDTO;
        }

        /// <summary>
        /// Get StateBullets, returning an Async task of a list of StateBulletsDTO
        /// </summary>
        /// <returns></returns>
        public async Task<List<StateBulletsDTO>> GetStateBullets()
        {
            // Get all StateBullets from the database
            var stateBullets = await _context.StateBullets.ToListAsync();
            var stateBulletsDTO = new List<StateBulletsDTO>();

            // For each StateBullets in the list of StateBullets
            stateBullets.ForEach(stateBullet =>
            {
                // Add a new StateBulletsDTO to the list of StateBulletsDTO
                stateBulletsDTO.Add(new StateBulletsDTO
                {
                    ID = stateBullet.ID,
                    GID = stateBullet.GID,
                    LabelX = stateBullet.LabelX,
                    LabelY = stateBullet.LabelY,
                    TextX = stateBullet.TextX,
                    TextY = stateBullet.TextY,
                    Name = stateBullet.Name
                });
            });

            return stateBulletsDTO;
        }
    }
}
