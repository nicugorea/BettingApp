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
        User GetUserById(int id);

        [OperationContract]
        bool RegisterResult(string username, string password);

        [OperationContract]
        bool LoginResult(string username, string password);

        [OperationContract]
        bool IsUser(int id);

        [OperationContract]
        bool IsAdmin(int id);

    }
}
