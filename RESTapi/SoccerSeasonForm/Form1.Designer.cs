﻿namespace SoccerSeasonForm
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeasons)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSeasons
            // 
            this.dataGridViewSeasons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSeasons.Location = new System.Drawing.Point(12, 53);
            this.dataGridViewSeasons.Name = "dataGridViewSeasons";
            this.dataGridViewSeasons.Size = new System.Drawing.Size(1445, 565);
            this.dataGridViewSeasons.TabIndex = 0;
            this.dataGridViewSeasons.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSeasons_CellContentClick);
            // 
            // SoccerSeasonsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 630);
            this.Controls.Add(this.dataGridViewSeasons);
            this.Name = "SoccerSeasonsForm";
            this.Text = "Soccer Seasons";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeasons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSeasons;
    }
}

