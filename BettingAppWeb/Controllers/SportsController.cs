using System.Web.Mvc;
using BettingAppWeb.Models;
using BettingAppWeb.Shared;

namespace BettingAppWeb.Controllers
{
    public class SportsController : Controller
    {
        public ActionResult Index()
        {
            return Redirect("~/Home/Index");
        }

        [HttpGet]
        public ActionResult Browse()
        {

            ViewData["SportsList"] = ManagerSingleton.Instance.SportsManager.GetSportsList();
            return View();
        }

        [HttpPost]
        public ActionResult Browse(SportViewModel sport)
        {
            ManagerSingleton.Instance.SportsManager.AddUpdate(sport);
            ViewData["SportsList"] = ManagerSingleton.Instance.SportsManager.GetSportsList();
            return View();
        }

        [HttpDelete]
        public ActionResult Delete(SportViewModel sport)
        {
            ManagerSingleton.Instance.SportsManager.DeleteSport(sport);
            return Redirect("~/Sports/Browse");
        }
    }
}