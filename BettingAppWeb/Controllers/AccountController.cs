using BettingAppWeb.Models;
using System.Web.Mvc;
using BettingAppWeb.AccountService;
using FootballBettingWeb;

namespace BettingAppWeb.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterViewModel user)
        {

            if (!ModelState.IsValid)
                return View(user);

            User principal = new User
            {
                Username = user.Username,
                Password = user.Password,
                Role = "user"
            };


            var registerResult = ServiceSingleton.Instance.AccountServiceClient.RegisterResult(principal);

            if (registerResult)
                return Redirect("Login");
            else
                return View();
        }



        public ActionResult ForgotPassword()
        {
            return View();
        }

    }
}