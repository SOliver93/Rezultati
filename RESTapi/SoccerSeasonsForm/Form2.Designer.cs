namespace SoccerSeasonsForm
{
    partial class FormLeague
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
            this.dataGridViewLeague = new System.Windows.Forms.DataGridView();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gamesPlayed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goalsScored = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goalDifference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.draws = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.izbornikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeague)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewLeague
            // 
            this.dataGridViewLeague.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLeague.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Position,
            this.teamName,
            this.gamesPlayed,
            this.points,
            this.goals,
            this.goalsScored,
            this.goalDifference,
            this.wins,
            this.draws,
            this.loses});
            this.dataGridViewLeague.Location = new System.Drawing.Point(12, 27);
            this.dataGridViewLeague.Name = "dataGridViewLeague";
            this.dataGridViewLeague.Size = new System.Drawing.Size(1342, 594);
            this.dataGridViewLeague.TabIndex = 0;
            this.dataGridViewLeague.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLeague_CellContentClick);
            // 
            // Position
            // 
            this.Position.DataPropertyName = "sPosition";
            this.Position.HeaderText = "Pozicija";
            this.Position.Name = "Position";
            // 
            // teamName
            // 
            this.teamName.DataPropertyName = "sTeamName";
            this.teamName.HeaderText = "Naziv tima";
            this.teamName.Name = "teamName";
            // 
            // gamesPlayed
            // 
            this.gamesPlayed.DataPropertyName = "sGamesPlayed";
            this.gamesPlayed.HeaderText = "Odigrane utakmice";
            this.gamesPlayed.Name = "gamesPlayed";
            // 
            // points
            // 
            this.points.DataPropertyName = "sPoints";
            this.points.HeaderText = "Broj bodova";
            this.points.Name = "points";
            // 
            // goals
            // 
            this.goals.DataPropertyName = "sGoals";
            this.goals.HeaderText = "Broj golova";
            this.goals.Name = "goals";
            // 
            // goalsScored
            // 
            this.goalsScored.DataPropertyName = "sGoalsAgainst";
            this.goalsScored.HeaderText = "Zabijeni golovi";
            this.goalsScored.Name = "goalsScored";
            // 
            // goalDifference
            // 
            this.goalDifference.DataPropertyName = "sGoalDifference";
            this.goalDifference.HeaderText = "Gol razlika";
            this.goalDifference.Name = "goalDifference";
            // 
            // wins
            // 
            this.wins.DataPropertyName = "sWins";
            this.wins.HeaderText = "Pobjede";
            this.wins.Name = "wins";
            // 
            // draws
            // 
            this.draws.DataPropertyName = "sDraws";
            this.draws.HeaderText = "Izjednačene utakmice";
            this.draws.Name = "draws";
            // 
            // loses
            // 
            this.loses.DataPropertyName = "sLosses";
            this.loses.HeaderText = "Porazi";
            this.loses.Name = "loses";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izbornikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1366, 24);
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
            // FormLeague
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 633);
            this.Controls.Add(this.dataGridViewLeague);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormLeague";
            this.Text = "League Table";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeague)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLeague;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gamesPlayed;
        private System.Windows.Forms.DataGridViewTextBoxColumn points;
        private System.Windows.Forms.DataGridViewTextBoxColumn goals;
        private System.Windows.Forms.DataGridViewTextBoxColumn goalsScored;
        private System.Windows.Forms.DataGridViewTextBoxColumn goalDifference;
        private System.Windows.Forms.DataGridViewTextBoxColumn wins;
        private System.Windows.Forms.DataGridViewTextBoxColumn draws;
        private System.Windows.Forms.DataGridViewTextBoxColumn loses;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem izbornikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
    }
}