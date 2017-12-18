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
        public FormLeague(SoccerSeasonsForm FormLeague)
        {
            FormLeagueList = FormLeague;
            InitializeComponent();

            REST League = new REST();
            List<LeagueTable> lLeague = League.GetLeagueTable();
            dataGridViewLeague.DataSource = lLeague;

            DataGridViewImageColumn oTablicaButton = new DataGridViewImageColumn();
            oTablicaButton.Image = Image.FromFile("D:/Repository/RESTapi/SoccerSeasonsForm/tablica.png");
            oTablicaButton.Width = 20;
            oTablicaButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewLeague.Columns.Add(oTablicaButton);

            DataGridViewImageColumn oTeamButton = new DataGridViewImageColumn();
            oTeamButton.Image = Image.FromFile("D:/Repository/RESTapi/SoccerSeasonsForm/team.png");
            oTeamButton.Width = 20;
            oTeamButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewLeague.Columns.Add(oTeamButton);            DataGridViewImageColumn oUtakmicaButton = new DataGridViewImageColumn();
            oUtakmicaButton.Image = Image.FromFile("D:/Repository/RESTapi/SoccerSeasonsForm/utakmica.png");
            oUtakmicaButton.Width = 20;
            oUtakmicaButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewLeague.Columns.Add(oUtakmicaButton);            dataGridViewLeague.AutoGenerateColumns = false;

        }
        public SoccerSeasonsForm WindowsFormUser { get; private set; }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
