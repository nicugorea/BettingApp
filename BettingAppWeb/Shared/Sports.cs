using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BettingAppWeb.Models;
using BettingAppWeb.SportService;

namespace BettingAppWeb.Shared
{
    public class Sports : ISports
    {
        public bool AddSport(SportViewModel sport)
        {
            var newSport = new Sport {
                Name = sport.Name,
                Description = sport.Description,
                Value = sport.Value,
                EndTime = sport.EndTime
            };

            return ServiceSingleton.Instance.SportServiceClient.AddSport(newSport);
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
    }
}