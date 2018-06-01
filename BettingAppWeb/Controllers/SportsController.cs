using BettingAppWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
            List<SportViewModel> list=new List<SportViewModel>();
            list.Add(new SportViewModel { Name = "Sport1", ID = 1 });
            list.Add(new SportViewModel { Name = "Spor", ID = 2 });
            list.Add(new SportViewModel { Name = "Spt1", ID = 3 });
            list.Add(new SportViewModel { Name = "Spordsada", ID = 4 });
            list.Add(new SportViewModel { Name = "Sportasdas", ID = 5 });
            list.Add(new SportViewModel { Name = "Sportdasd", ID = 6 });
            list.Add(new SportViewModel { Name = "Sporasdas1", ID = 7 });
            list.Add(new SportViewModel { Name = "Sportasdas", ID = 8 });



            return View(list);
        }
    }
}