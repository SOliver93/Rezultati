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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeasons)).BeginInit();
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
            this.LastUpdated});
            this.dataGridViewSeasons.Location = new System.Drawing.Point(12, 54);
            this.dataGridViewSeasons.Name = "dataGridViewSeasons";
            this.dataGridViewSeasons.Size = new System.Drawing.Size(1323, 538);
            this.dataGridViewSeasons.TabIndex = 0;
            this.dataGridViewSeasons.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "sID";
            this.ID.HeaderText = "Redni broj";
            this.ID.Name = "ID";
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
            // SoccerSeasonsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 604);
            this.Controls.Add(this.dataGridViewSeasons);
            this.Name = "SoccerSeasonsForm";
            this.Text = "Soccer Seasons";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeasons)).EndInit();
            this.ResumeLayout(false);

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
    }
}

