using System.ServiceModel;

namespace BettingAppWcf.Services
{
    [ServiceContract]
    public interface IAccountService
    {
        [OperationContract]
        string DoWork();
    }
}
