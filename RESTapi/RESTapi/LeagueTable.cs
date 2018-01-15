using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTapi
{
    public class LeagueTable
    {
        public string sPosition { get; set; }
        public string sTeamName { get; set; }
        public string sGamesPlayed { get; set; }
        public string sPoints { get; set; }
        public string sGoals { get; set; }
        public string sGoalsAgainst { get; set; }
        public string sGoalDifference { get; set; }
        public string sWins { get; set; }
        public string sDraws { get; set; }
        public string sLosses { get; set; }
    }
}
