using System.Web.Mvc;
using BettingAppWeb.Shared;

namespace BettingAppWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (ManagerSingleton.Instance.AuthenticationManager.IsUserLoggedIn())
            {
                if (ManagerSingleton.Instance.AuthenticationManager.IsUser())
                    return Redirect("~/Home/UserIndex");
                if (ManagerSingleton.Instance.AuthenticationManager.IsAdmin())
                    return Redirect("~/Home/AdminIndex");

            }
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult UserIndex()
        {
            if (!ManagerSingleton.Instance.AuthenticationManager.IsUserLoggedIn())
                return Redirect("~/Home/Index");
            return View();
        }

        public ActionResult AdminIndex()
        {
            if (!ManagerSingleton.Instance.AuthenticationManager.IsUserLoggedIn())
                return Redirect("~/Home/Index");
            return View();
        }


    }
}