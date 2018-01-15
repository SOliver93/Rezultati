namespace SoccerSeasonsForm
{
    partial class TeamsForm
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
            this.dataGridViewTeams = new System.Windows.Forms.DataGridView();
            this.Teams = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeams)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTeams
            // 
            this.dataGridViewTeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Teams});
            this.dataGridViewTeams.Location = new System.Drawing.Point(12, 41);
            this.dataGridViewTeams.Name = "dataGridViewTeams";
            this.dataGridViewTeams.Size = new System.Drawing.Size(1425, 580);
            this.dataGridViewTeams.TabIndex = 0;
            // 
            // Teams
            // 
            this.Teams.DataPropertyName = "sTeamName";
            this.Teams.HeaderText = "Timovi";
            this.Teams.Name = "Teams";
            this.Teams.Width = 125;
            // 
            // TeamsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1449, 633);
            this.Controls.Add(this.dataGridViewTeams);
            this.Name = "TeamsForm";
            this.Text = "Teams";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeams)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTeams;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teams;
    }
}