namespace BettingAppWeb.Shared
{
    public class Authentication : IAuthentication
    {
        public Authentication()
        {
            LocalUserId = -1;
        }

        public int LocalUserId { get; set; }

        public bool IsAdmin()
        {
            return ServiceSingleton.Instance.AccountServiceClient.IsAdmin(LocalUserId);
        }

        public bool IsUser()
        {
            return ServiceSingleton.Instance.AccountServiceClient.IsUser(LocalUserId);
        }

        public bool IsUserLoggedIn()
        {
            return LocalUserId != -1;
        }

        public bool LoginUserByCredentials(string username, string password)
        {

            if (ServiceSingleton.Instance.AccountServiceClient.LoginResult(username, password))
                LocalUserId = ServiceSingleton.Instance.AccountServiceClient.GetUserByUsername(username).ID_User;
            else return false;
            return true;

        }

        public bool LogoutUser()
        {
            LocalUserId = -1;
            return true;
        }
    }
}