using System.Collections.Generic;
using System.ServiceModel;
using BettingAppWcf.Models;

namespace BettingAppWcf.Services
{
    [ServiceContract]
    public interface ISportService
    {

        [OperationContract]
        List<Sport> GetSportsList();

        [OperationContract]
        Sport GetSportById(int id);

        [OperationContract]
        bool AddSport(Sport sport);

        [OperationContract]
        bool RemoveSport(int id);

        [OperationContract]
        bool UpdateSport(Sport sport);

    }
}
