using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BettingAppWeb.Shared
{
    public class ManagerSingleton
    {

        private static ManagerSingleton _instance = null;
        private Authentication _authenticationManager = null;
        private Sports _sportsManager = null;

        public static ManagerSingleton Instance
        {
            get
            {
                if(_instance==null)
                {
                    _instance = new ManagerSingleton();
                }
                return _instance;
            }
        }

        public Authentication AuthenticationManager
        {
            get
            {
                if (_authenticationManager == null)
                {
                    _authenticationManager = new Authentication();
                }
                return _authenticationManager;
            }
        }

        public Sports SportsManager
        {
            get
            {
                if (_sportsManager == null)
                {
                    _sportsManager = new Sports();
                }
                return _sportsManager;
            }
        }


    }
}