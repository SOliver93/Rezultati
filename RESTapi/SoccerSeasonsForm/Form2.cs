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
    public partial class FormLeague : Form
    {
        private readonly SoccerSeasonsForm FormLeagueList;
        public string LeagueLink;
        public FormLeague(SoccerSeasonsForm FormLeague, string sUrl)
        {
            LeagueLink = sUrl;
            FormLeagueList = FormLeague;
            InitializeComponent();

            REST League = new REST();
            List<LeagueTable> lLeague = League.GetLeagueTable(LeagueLink);
            dataGridViewLeague.DataSource = lLeague;            
        }
        public SoccerSeasonsForm WindowsFormUser { get; private set; }

        private void dataGridViewLeague_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
