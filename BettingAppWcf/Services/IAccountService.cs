using BettingAppWcf.Models;
using System.ServiceModel;

namespace BettingAppWcf.Services
{
    [ServiceContract]
    public interface IAccountService
    {
        [OperationContract]
        User GetUserByUsername(string username);

        [OperationContract]
        bool RegisterResult(User user);
        

    }
}
