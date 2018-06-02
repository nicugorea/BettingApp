using BettingAppWeb.Models;
using System.Collections.Generic;

namespace BettingAppWeb.Shared
{
    interface ISports
    {
         List<SportViewModel> GetSportsList();
        bool AddSport(SportViewModel sport);
    }
}
