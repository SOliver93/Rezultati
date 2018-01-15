namespace SoccerSeasonsForm
{
    partial class SoccerSeasonsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewSeasons = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Caption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.League = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentMatchday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfMatchdays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfTeams = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfGames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastUpdated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Table = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fixtures = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teams = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.izbornikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeasons)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewSeasons
            // 
            this.dataGridViewSeasons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSeasons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Caption,
            this.League,
            this.Year,
            this.CurrentMatchday,
            this.NumberOfMatchdays,
            this.NumberOfTeams,
            this.NumberOfGames,
            this.LastUpdated,
            this.Table,
            this.Fixtures,
            this.Teams});
            this.dataGridViewSeasons.Location = new System.Drawing.Point(12, 27);
            this.dataGridViewSeasons.Name = "dataGridViewSeasons";
            this.dataGridViewSeasons.Size = new System.Drawing.Size(1323, 565);
            this.dataGridViewSeasons.TabIndex = 0;
            this.dataGridViewSeasons.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "sID";
            this.ID.HeaderText = "Redni broj";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Caption
            // 
            this.Caption.DataPropertyName = "sCaption";
            this.Caption.HeaderText = "Naziv";
            this.Caption.Name = "Caption";
            this.Caption.Width = 200;
            // 
            // League
            // 
            this.League.DataPropertyName = "sLeague";
            this.League.HeaderText = "Liga";
            this.League.Name = "League";
            // 
            // Year
            // 
            this.Year.DataPropertyName = "sYear";
            this.Year.HeaderText = "Godina";
            this.Year.Name = "Year";
            // 
            // CurrentMatchday
            // 
            this.CurrentMatchday.DataPropertyName = "sCurrentMatchday";
            this.CurrentMatchday.HeaderText = "Broj utakmice";
            this.CurrentMatchday.Name = "CurrentMatchday";
            // 
            // NumberOfMatchdays
            // 
            this.NumberOfMatchdays.DataPropertyName = "sNumberOfMatchdays";
            this.NumberOfMatchdays.HeaderText = "Ukupan broj utakmica";
            this.NumberOfMatchdays.Name = "NumberOfMatchdays";
            // 
            // NumberOfTeams
            // 
            this.NumberOfTeams.DataPropertyName = "sNumberOfTeams";
            this.NumberOfTeams.HeaderText = "Broj timova";
            this.NumberOfTeams.Name = "NumberOfTeams";
            // 
            // NumberOfGames
            // 
            this.NumberOfGames.DataPropertyName = "sNumberOfGames";
            this.NumberOfGames.HeaderText = "Ukupan broj utakmica u ligi";
            this.NumberOfGames.Name = "NumberOfGames";
            // 
            // LastUpdated
            // 
            this.LastUpdated.DataPropertyName = "sLastUpdated";
            this.LastUpdated.HeaderText = "Zadnje ažurirano";
            this.LastUpdated.Name = "LastUpdated";
            this.LastUpdated.Width = 150;
            // 
            // Table
            // 
            this.Table.DataPropertyName = "sLeagueTable";
            this.Table.HeaderText = "Tablica lige";
            this.Table.Name = "Table";
            this.Table.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Table.Visible = false;
            // 
            // Fixtures
            // 
            this.Fixtures.DataPropertyName = "sFixtures";
            this.Fixtures.HeaderText = "Odigrane utakmice";
            this.Fixtures.Name = "Fixtures";
            this.Fixtures.Visible = false;
            // 
            // Teams
            // 
            this.Teams.DataPropertyName = "sTeams";
            this.Teams.HeaderText = "Timovi";
            this.Teams.Name = "Teams";
            this.Teams.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izbornikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1347, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // izbornikToolStripMenuItem
            // 
            this.izbornikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izlazToolStripMenuItem});
            this.izbornikToolStripMenuItem.Name = "izbornikToolStripMenuItem";
            this.izbornikToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.izbornikToolStripMenuItem.Text = "Izbornik";
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            this.izlazToolStripMenuItem.Click += new System.EventHandler(this.izlazToolStripMenuItem_Click);
            // 
            // SoccerSeasonsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 604);
            this.Controls.Add(this.dataGridViewSeasons);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SoccerSeasonsForm";
            this.Text = "Soccer Seasons";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeasons)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSeasons;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caption;
        private System.Windows.Forms.DataGridViewTextBoxColumn League;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentMatchday;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfMatchdays;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfTeams;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfGames;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastUpdated;
        private System.Windows.Forms.DataGridViewTextBoxColumn Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fixtures;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teams;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem izbornikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
    }
}

