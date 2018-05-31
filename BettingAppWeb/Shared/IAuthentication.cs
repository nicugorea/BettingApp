namespace BettingAppWeb.Shared
{


    interface IAuthentication
    {
        bool IsUserLoggedIn();
        bool LoginUserByCredentials(string username, string password);
        bool IsUser();
        bool IsAdmin();
        bool LogoutUser();
    }
}
