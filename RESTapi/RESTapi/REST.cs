using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RESTapi
{
    public class REST
    {
        public List<SoccerSeason> lSeasons = new List<SoccerSeason>();
        public List<LeagueTable> lLeague = new List<LeagueTable>();
        public static string CallRestMethod(string url)
        {
            HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(url);
            webrequest.Method = "GET";
            webrequest.ContentType = "application/x-www-form-urlencoded";
            HttpWebResponse webresponse = (HttpWebResponse)webrequest.GetResponse();
            Encoding enc = System.Text.Encoding.GetEncoding("utf-8");
            StreamReader responseStream = new StreamReader(webresponse.GetResponseStream(),
            enc);
            string result = string.Empty;
            result = responseStream.ReadToEnd();
            webresponse.Close();
            return result;
        }
        public List<SoccerSeason> GetSoccerSeasons()
        {
            List<SoccerSeason> lRESTSeasons = new List<SoccerSeason>();
            string sUrl = System.Configuration.ConfigurationManager.AppSettings["RestApiUrl"];
            string sJson = CallRestMethod(sUrl);
            JArray aJson = JArray.Parse(sJson);
            foreach (JObject item in aJson)
            {
                string ID = (string)item.GetValue("id");
                string Caption = (string)item.GetValue("caption");
                string League = (string)item.GetValue("league");
                string Year = (string)item.GetValue("year");
                string CurrentMatchday = (string)item.GetValue("currentMatchday");
                string NumberOfMatchdays = (string)item.GetValue("numberOfMatchdays");
                string NumberOfTeams = (string)item.GetValue("numberOfTeams");
                string NumberOfGames = (string)item.GetValue("numberOfGames");
                string LastUpdated = (string)item.GetValue("lastUpdated");
                lRESTSeasons.Add(new SoccerSeason
                {
                    sID = ID,
                    sCaption = Caption,
                    sLeague = League,
                    sYear = Year,
                    sCurrentMatchday = CurrentMatchday,
                    sNumberOfMatchdays = NumberOfMatchdays,
                    sNumberOfTeams = NumberOfTeams,
                    sNumberOfGames = NumberOfGames,
                    sLastUpdated = LastUpdated
                });
            }
            return lRESTSeasons;
        }       
        public List<LeagueTable> GetLeagueTable()
        {
            List<LeagueTable> lRESTLeague = new List<LeagueTable>();
            string sUrl = System.Configuration.ConfigurationManager.AppSettings["RestApiUrl"];
            string sJson = CallRestMethod(sUrl);
            JArray aJson = JArray.Parse(sJson);
            foreach (JObject item in aJson)
            {
                string Position = (string)item.GetValue("position");
                string TeamName = (string)item.GetValue("teamName");
                string PlayedGames = (string)item.GetValue("playedGames");
                string Points = (string)item.GetValue("points");
                string Goals = (string)item.GetValue("goals");
                string GoalsAgainst = (string)item.GetValue("goalsAgainst");
                string GoalDifference = (string)item.GetValue("goalDifference");
                string Wins = (string)item.GetValue("wins");
                string Draws = (string)item.GetValue("draws");
                string Loses = (string)item.GetValue("loses");
                lRESTLeague.Add(new LeagueTable
                {
                    sPosition = Position,
                    sTeamName = TeamName,
                    sGamesPlayed = PlayedGames,
                    sPoints = Points,
                    sGoals = Goals,
                    sGoalsAgainst = GoalsAgainst,
                    sGoalDifference = GoalDifference,
                    sWins = Wins,
                    sDraws = Draws,
                    sLoses = Loses
                });
            }
            return lRESTLeague;
        }
    }               
}
