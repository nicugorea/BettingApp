namespace BettingAppWeb.Shared
{


    interface IAuthentication
    {
        bool IsUserLoggedIn();
        bool LoginUserByCredentials(string username, string password);
        bool RegisterUserByCredentials(string username, string password);
        bool IsUser();
        bool IsAdmin();
        bool LogoutUser();
        string GetUserNickname();
    }
}
