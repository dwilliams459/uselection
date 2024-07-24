using USElections.Data.Models;
using USElections.Shared.DTOs;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace USElections.Repos.Events
{
    public class EventsRepository(USElectionsDBContext context) : IEventsRepository
    {
        private readonly USElectionsDBContext _context = context;

        public async Task<IEnumerable<EventDTO>> GetEventsAsync()
        {
            var query = _context.Events
                .Include(e => e.EventType)
                .Select(e => new EventDTO()
                {
                    EventId = e.EventId,
                    EventTypeId = e.EventTypeId,
                    EventTypeName = e.EventType.EventTypeName,
                    EventName = e.EventName,
                    EventDate = e.EventDate,
                    StartTime = e.StartTime,
                    EndTime = e.EndTime,
                    Location = e.Location,
                    Description = e.Description
                });

            return query.ToList();
        }

        public async Task<IEnumerable<EventDTO>> GetSocialClubEventsAsync()
        {
            var query = _context.Events
                .Include(e => e.EventType)
                .Where(e => e.EventType.EventTypeName == "Social Club")
                .Select(e => new EventDTO()
                {
                    EventId = e.EventId,
                    EventTypeId = e.EventTypeId,
                    EventTypeName = e.EventType.EventTypeName,
                    EventName = e.EventName,
                    EventDate = e.EventDate,
                    StartTime = e.StartTime,
                    EndTime = e.EndTime,
                    Location = e.Location,
                    Description = e.Description
                });

            return query.ToList();
        }
    }
}
