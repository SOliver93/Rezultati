using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RESTapi;

namespace SoccerSeasonsForm
{
    public partial class TeamsForm : Form
    {
        private readonly SoccerSeasonsForm TeamsFormList;
        public string LeagueLink3;
        public TeamsForm(SoccerSeasonsForm TeamsForm, string sUrl3)
        {
            LeagueLink3 = sUrl3;
            TeamsFormList = TeamsForm;
            InitializeComponent();

            REST Teams = new REST();
            List<Teams> lTeams = Teams.GetTeams(LeagueLink3);
            dataGridViewTeams.DataSource = lTeams;
        }
        public SoccerSeasonsForm WindowsFormUser { get; private set; }
    }
}
