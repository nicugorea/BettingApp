using System;
using System.Web.Mvc;
using BettingAppWeb.Models;
using BettingAppWeb.Shared;

namespace BettingAppWeb.Controllers
{
    public class SportsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Browse()
        {

            var sport = new SportViewModel {
                Name = "Football",
                Description = "A game with a ball",
                Value = 24,
            };
            sport.EndTime = DateTime.Now;

            ManagerSingleton.Instance.SportsManager.AddSport(sport);
            var list = ManagerSingleton.Instance.SportsManager.GetSportsList();
            
           
            return View(list);
        }
    }
}