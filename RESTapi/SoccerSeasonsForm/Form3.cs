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
    public partial class FixturesForm : Form
    {
        private readonly SoccerSeasonsForm FixturesFormList;
        public string LeagueLink2;
        public FixturesForm(SoccerSeasonsForm FixturesForm, string sUrl2)
        {
            LeagueLink2 = sUrl2;
            FixturesFormList = FixturesForm;
            InitializeComponent();

            REST Fixtures = new REST();
            List<Fixtures> lFixtures = Fixtures.GetFixtures(LeagueLink2);
            dataGridViewFixtures.DataSource = lFixtures;
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
