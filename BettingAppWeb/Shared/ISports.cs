using BettingAppWeb.Models;
using BettingAppWeb.SportService;
using System.Collections.Generic;

namespace BettingAppWeb.Shared
{
    interface ISports
    {
        List<SportViewModel> GetSportsList();

        bool AddSport(SportViewModel sport);

        bool UpdateSport(SportViewModel sport);

        bool DeleteSport(SportViewModel sport);

        bool AddUpdate(SportViewModel sport);

        Sport GetSportFromViewModel(SportViewModel sport);
    }
}
