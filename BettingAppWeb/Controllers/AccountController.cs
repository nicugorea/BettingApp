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
                return Redirect("~/Home/Index");
        }

        #region login
        [HttpGet]
        public ActionResult Login()
        {
            if (ManagerSingleton.Instance.AuthenticationManager.IsUserLoggedIn())
                return Redirect("~/Home/Index");
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel user)
        {
            if (ManagerSingleton.Instance.AuthenticationManager.IsUserLoggedIn())
                return Redirect("~/Home/Index");
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
            if (ManagerSingleton.Instance.AuthenticationManager.IsUserLoggedIn())
                return Redirect("~/Home/Index");
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterViewModel user)
        {
            if (ManagerSingleton.Instance.AuthenticationManager.IsUserLoggedIn())
                return Redirect("~/Home/Index");
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
            if (ManagerSingleton.Instance.AuthenticationManager.IsUserLoggedIn())
                return Redirect("~/Home/Index");
            return View();
        }

        public ActionResult Logout()
        {
            if (!ManagerSingleton.Instance.AuthenticationManager.IsUserLoggedIn())
                return Redirect("~/Home/Index");
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