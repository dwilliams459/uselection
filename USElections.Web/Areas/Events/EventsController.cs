using USElections.Repos.Events;
using USElections.Shared.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace USElections.Web.Areas.SocialClub
{
    [Area("Events")]
    public class EventsController : Controller
    {
        private readonly IEventsRepository _eventsRepository;
        public EventsController(IEventsRepository eventsRepository) 
        { 
            _eventsRepository = eventsRepository;
        }

        [HttpGet]
        [Route("/Events/GetEvents")]
        public async Task<IActionResult> GetEvents()
        {
            var response = await _eventsRepository.GetEventsAsync();

            return Json(response);
        }

        [HttpGet]
        [Route("/Events/GetSocialClubEvents")]
        public async Task<IActionResult> GetSocialClubEvents()
        {
            var response = await _eventsRepository.GetSocialClubEventsAsync();

            return Json(response);
        }
    }
}
