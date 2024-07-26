//using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using USElections.Repos;
using USElections.Repos.Interfaces;
using USElections.Shared.DTOs;
using USElections.WASM.Repos.USStates;

namespace USElections.Web.Controllers
{
    public class USStatesController : Controller
    {
        public IUSStateRepo _stateRepo {  get; set; }

        public USStatesController(IUSStateRepo stateRepo)
        {
            _stateRepo = stateRepo;
        }

        [HttpGet]
        [Route("usstates")]
        public async Task<IActionResult> GetUSStates()
        {
            List<USStateDTO> states = await _stateRepo.GetUSStates();

            return Json(states);
        }
    }
}
