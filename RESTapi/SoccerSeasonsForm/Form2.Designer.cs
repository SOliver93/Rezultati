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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeague)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLeague
            // 
            this.dataGridViewLeague.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLeague.Location = new System.Drawing.Point(12, 53);
            this.dataGridViewLeague.Name = "dataGridViewLeague";
            this.dataGridViewLeague.Size = new System.Drawing.Size(1431, 566);
            this.dataGridViewLeague.TabIndex = 0;
            this.dataGridViewLeague.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FormLeague
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 631);
            this.Controls.Add(this.dataGridViewLeague);
            this.Name = "FormLeague";
            this.Text = "Soccer Season League Table";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeague)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLeague;
    }
}