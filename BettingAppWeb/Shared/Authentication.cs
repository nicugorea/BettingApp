namespace BettingAppWeb.Shared
{
    public class Authentication : IAuthentication
    {
        public Authentication()
        {
            LocalUserId = -1;
        }

        public int LocalUserId { get; set; }

        public string GetUserNickname()
        {
            return ServiceSingleton.Instance.AccountServiceClient.GetUserById(LocalUserId).Username;
        }

        public bool IsAdmin()
        {
            if (!IsUserLoggedIn()) return false;
            return ServiceSingleton.Instance.AccountServiceClient.IsAdmin(LocalUserId);
        }

        public bool IsUser()
        {
            if (!IsUserLoggedIn()) return false;
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

        public bool RegisterUserByCredentials(string username, string password)
        {
            return ServiceSingleton.Instance.AccountServiceClient.RegisterResult(username, password);
        }
    }
}