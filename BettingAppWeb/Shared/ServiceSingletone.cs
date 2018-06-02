using BettingAppWeb.AccountService;
using BettingAppWeb.SportService;

namespace BettingAppWeb.Shared
{
    public class ServiceSingleton
    {
        private static ServiceSingleton _instance = null;
        private AccountServiceClient _accountServiceClient = null;
        private SportServiceClient _sportServiceClient = null;

        private ServiceSingleton() { }

        public AccountServiceClient AccountServiceClient
        {
            get
            {
                if (_accountServiceClient == null)
                {
                    _accountServiceClient = new AccountServiceClient();
                }
                return _accountServiceClient;
            }
        }

        public SportServiceClient SportServiceClient
        {
            get
            {
                if (_sportServiceClient == null)
                {    
                    _sportServiceClient = new SportServiceClient();
                }
                return _sportServiceClient;
            }
        }


        public static ServiceSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ServiceSingleton();
                }
                return _instance;
            }
        }
    }
}
