using System.Collections.Generic;
using BettingAppWeb.Models;
using BettingAppWeb.SportService;

namespace BettingAppWeb.Shared
{
    public class Sports : ISports
    {
        public bool AddUpdate(SportViewModel sport)
        {
            if(ServiceSingleton.Instance.SportServiceClient.ExistSportByName(sport.Name))
            {
                return UpdateSport(sport);
            }
            else
            {
                return AddSport(sport);
            }
        }

        public bool AddSport(SportViewModel sport)
        {
            return ServiceSingleton.Instance.SportServiceClient.AddSport(
                GetSportFromViewModel(sport)
                );
        }

        public List<SportViewModel> GetSportsList()
        {
            var list = ServiceSingleton.Instance.SportServiceClient.GetSportsList();

            var sportsList = new List<SportViewModel>();
            foreach (var sport in list)
            {
                sportsList.Add(new SportViewModel
                {
                    SportId = sport.SportID,
                    Name = sport.Name,
                    Description = sport.Description,
                    Value = sport.Value,
                    EndTime = sport.EndTime
                });
            }

            return sportsList;
        }

        public bool UpdateSport(SportViewModel sport)
        {
            return ServiceSingleton.Instance.SportServiceClient.UpdateSport(
                GetSportFromViewModel(sport)
                );
            
        }

        public Sport GetSportFromViewModel(SportViewModel sport)
        {
            Sport newSport = new Sport
            {
                Name = sport.Name,
                Description=sport.Description,
                Value=sport.Value,
                EndTime=sport.EndTime
            };
            return newSport;
        }

        public bool DeleteSport(SportViewModel sport)
        {
            var toDelete = ServiceSingleton.Instance.SportServiceClient.GetSportByName(sport.Name);
            if (toDelete == null) return false;
            return ServiceSingleton.Instance.SportServiceClient.RemoveSport(toDelete.SportID);
        }
    }
}