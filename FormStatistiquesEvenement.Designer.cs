namespace AppContactEvenementM2Lv5
{
    partial class FormStatistiquesEvenement
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
            this.dgvStats = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStats)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStats
            // 
            this.dgvStats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStats.Location = new System.Drawing.Point(126, 12);
            this.dgvStats.Name = "dgvStats";
            this.dgvStats.RowHeadersWidth = 51;
            this.dgvStats.RowTemplate.Height = 29;
            this.dgvStats.Size = new System.Drawing.Size(783, 318);
            this.dgvStats.TabIndex = 0;
            this.dgvStats.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStats_CellContentClick);
            // 
            // FormStatistiquesEvenement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 510);
            this.Controls.Add(this.dgvStats);
            this.Name = "FormStatistiquesEvenement";
            this.Text = "FormStatistiquesEvenement";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStats)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvStats;
    }
}