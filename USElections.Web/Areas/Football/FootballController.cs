using USElections.Repos.Football;
using USElections.WASM.Repos.Football;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace USElections.Web.Areas.Football
{
    [Area("Football")]
    public class FootballController : Controller
    {
        private readonly IfootballRepo _footballRepo;

        public FootballController(IfootballRepo footballRepo)
        {

            _footballRepo = footballRepo;

        }
        [HttpGet]
        [Route("/Football/GetTeams")]
        public IActionResult GetTeamsList()
        {
            var result = _footballRepo.GetTeamList();
            return Json(result);
        }

        [Route("/Football/GetTeamDetails/{teamId}")]
        public IActionResult GetTeamDetailsList(string teamId)
        {
            var result = _footballRepo.GetTeamDetails(Convert.ToInt32(teamId));
            return Json(result);
        }
        [Route("/Football/GetTest/{teamId}")]
        public IActionResult GetTestList(string teamId)
        {
            return Json("result");
        }
    }
}
