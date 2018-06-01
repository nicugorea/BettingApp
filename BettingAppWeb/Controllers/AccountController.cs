using BettingAppWeb.Models;
using System.Web.Mvc;
using BettingAppWeb.AccountService;
using BettingAppWeb.Shared;

namespace BettingAppWeb.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        #region login
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel user)
        {
            if (ManagerSingleton.Instance.AuthenticationManager.LoginUserByCredentials
                (user.Username, user.Password))
            {
                if (ManagerSingleton.Instance.AuthenticationManager.IsAdmin())
                    return Redirect("~/Home/AdminIndex");
                if (ManagerSingleton.Instance.AuthenticationManager.IsUser())
                    return Redirect("~/Home/Index");
            }
            return View();
        }
        #endregion

        #region register
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

            if (ManagerSingleton.Instance.AuthenticationManager.RegisterUserByCredentials(user.Username, user.Password))
                return Redirect("Login");
            else
                return View();
        }
        #endregion

        public ActionResult ForgotPassword()
        {
            return View();
        }

        public ActionResult Logout()
        {
            ManagerSingleton.Instance.AuthenticationManager.LogoutUser();
            return Redirect("~/Home/Index");
        }

        public ActionResult MyAccount()
        {
            if (!ManagerSingleton.Instance.AuthenticationManager.IsUserLoggedIn())
                return Redirect("~/Home/Index");
            return View();
        }
    }
}