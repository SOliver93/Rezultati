using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Diagnostics;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace SoccerSeasonForm
{
    public partial class SoccerSeasonsForm : Form
    {
        public List<SoccerSeason> lSeasons = new List<SoccerSeason>();
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
        public List<SoccerSeason> GetSocerSeasons()
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
                string CurrentMatchday = (string)item.GetValue("year");
                string NumberOfMatchdays = (string)item.GetValue("currentMatchday");                
                string NumberOfTeams = (string)item.GetValue("numberOfTeams");
                string NumberOfGames = (string)item.GetValue("numberOfGames");
                string LastUpdated = (string)item.GetValue("lastUpdated");
                lRESTSeasons.Add(new SoccerSeason
                {
                    sID = ID,
                    sCaption = Caption,
                    sLeague = League,
                    sCurrentMatchday = CurrentMatchday,
                    sNumberOfMatchdays = NumberOfMatchdays,
                    sNumberOfTeams = NumberOfTeams,
                    sNumberOfGames = NumberOfGames,
                    sLastUpdated = LastUpdated
                });
            }
            return lRESTSeasons;
        }
        public SoccerSeasonsForm()
        {
            InitializeComponent();

            /*DATA GRID*/
            lSeasons = GetSocerSeasons();
            dataGridViewSeasons.DataSource = lSeasons;            
        }

        private void dataGridViewSeasons_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
