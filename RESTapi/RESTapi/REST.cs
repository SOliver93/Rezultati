using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace RESTapi
{
    public class REST
    {
        public List<SoccerSeason> lSeasons = new List<SoccerSeason>();
        public List<LeagueTable> lLeague = new List<LeagueTable>();
        public List<Fixtures> lFixtures = new List<Fixtures>();
        public List<Teams> lTeams = new List<Teams>();
        public static string CallRestMethod(string url)
        {
            HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(url);
            webrequest.Method = "GET";
            webrequest.ContentType = "application/x-www-form-urlencoded";
            HttpWebResponse webresponse = (HttpWebResponse)webrequest.GetResponse();
            var Response = webresponse.StatusCode;                        
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
                string LeagueTable = (string)item["_links"]["leagueTable"]["href"];
                string Fixtures = (string)item["_links"]["fixtures"]["href"];
                string Teams = (string)item["_links"]["teams"]["href"];
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
                    sLastUpdated = LastUpdated,
                    sLeagueTable = LeagueTable,
                    sFixtures = Fixtures,
                    sTeams = Teams
                });
            }
            return lRESTSeasons;
        }
        public List<LeagueTable> GetLeagueTable(string sUrl)
        {
            Debug.WriteLine(sUrl);                      
            string sJson = CallRestMethod(sUrl);
            JObject oJson = JObject.Parse(sJson);
            var oLeagueTable = oJson["standing"].ToList();
            List<LeagueTable> lRESTLeague = new List<LeagueTable>();
            for (int i = 0; i < oLeagueTable.Count; i++)
            {
                lRESTLeague.Add(new LeagueTable
                {
                    sPosition = (string)oLeagueTable[i]["position"],
                    sTeamName = (string)oLeagueTable[i]["teamName"],
                    sGamesPlayed = (string)oLeagueTable[i]["playedGames"],
                    sPoints = (string)oLeagueTable[i]["points"],
                    sGoals = (string)oLeagueTable[i]["goals"],
                    sGoalsAgainst = (string)oLeagueTable[i]["goalsAgainst"],
                    sGoalDifference = (string)oLeagueTable[i]["goalDifference"],
                    sWins = (string)oLeagueTable[i]["wins"],
                    sDraws = (string)oLeagueTable[i]["draws"],
                    sLosses = (string)oLeagueTable[i]["losses"]
                });
            }            
            return lRESTLeague;
        }

        public List<Fixtures> GetFixtures(string sUrl2)
        {
            Debug.WriteLine(sUrl2);
            string sJson = CallRestMethod(sUrl2);
            JObject oJson = JObject.Parse(sJson);
            var oFixtures = oJson["fixtures"].ToList();
            List<Fixtures> lRESTFixtures = new List<Fixtures>();
            for (int i = 0; i < oFixtures.Count; i++)
            {
                lRESTFixtures.Add(new Fixtures
                {
                    sFixtureDate = (string)oFixtures[i]["date"],
                    sFixtureMatchday = (string)oFixtures[i]["matchday"],
                    sHomeTeamName = (string)oFixtures[i]["homeTeamName"],
                    sAwayTeamName = (string)oFixtures[i]["awayTeamName"],
                    sGoalsHomeTeam = (string)oFixtures[i]["result"]["goalsHomeTeam"],
                    sGoalsAwayTeam = (string)oFixtures[i]["result"]["goalsAwayTeam"],                    
                });
            }
            return lRESTFixtures;
        }

        public List<Teams> GetTeams(string sUrl3)
        {
            Debug.WriteLine(sUrl3);
            string sJson = CallRestMethod(sUrl3);
            JObject oJson = JObject.Parse(sJson);
            var oTeams = oJson["teams"].ToList();
            List<Teams> lRESTTeams = new List<Teams>();
            for (int i = 0; i < oTeams.Count; i++)
            {
                lRESTTeams.Add(new Teams
                {
                    sTeamName = (string)oTeams[i]["name"]                   
                });
            }
            return lRESTTeams;
        }
    }               
}

