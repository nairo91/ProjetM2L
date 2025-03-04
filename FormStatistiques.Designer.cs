namespace AppContactEvenementM2Lv5
{
    partial class FormStatistiques
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
            this.lblNbUtilisateurs = new System.Windows.Forms.Label();
            this.lblNbEvenements = new System.Windows.Forms.Label();
            this.lblTauxParticipation = new System.Windows.Forms.Label();
            this.btnRafraichirStats = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNbUtilisateurs
            // 
            this.lblNbUtilisateurs.AutoSize = true;
            this.lblNbUtilisateurs.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNbUtilisateurs.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblNbUtilisateurs.Location = new System.Drawing.Point(36, 49);
            this.lblNbUtilisateurs.Name = "lblNbUtilisateurs";
            this.lblNbUtilisateurs.Size = new System.Drawing.Size(158, 23);
            this.lblNbUtilisateurs.TabIndex = 0;
            this.lblNbUtilisateurs.Text = "Nombre d'utilisateurs :";
            // 
            // lblNbEvenements
            // 
            this.lblNbEvenements.AutoSize = true;
            this.lblNbEvenements.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNbEvenements.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblNbEvenements.Location = new System.Drawing.Point(36, 110);
            this.lblNbEvenements.Name = "lblNbEvenements";
            this.lblNbEvenements.Size = new System.Drawing.Size(166, 23);
            this.lblNbEvenements.TabIndex = 1;
            this.lblNbEvenements.Text = "Nombre d'événements :";
            // 
            // lblTauxParticipation
            // 
            this.lblTauxParticipation.AutoSize = true;
            this.lblTauxParticipation.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTauxParticipation.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTauxParticipation.Location = new System.Drawing.Point(36, 173);
            this.lblTauxParticipation.Name = "lblTauxParticipation";
            this.lblTauxParticipation.Size = new System.Drawing.Size(155, 23);
            this.lblTauxParticipation.TabIndex = 2;
            this.lblTauxParticipation.Text = "Taux de participation :";
            // 
            // btnRafraichirStats
            // 
            this.btnRafraichirStats.BackColor = System.Drawing.Color.Navy;
            this.btnRafraichirStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRafraichirStats.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRafraichirStats.ForeColor = System.Drawing.Color.White;
            this.btnRafraichirStats.Location = new System.Drawing.Point(45, 357);
            this.btnRafraichirStats.Name = "btnRafraichirStats";
            this.btnRafraichirStats.Size = new System.Drawing.Size(125, 29);
            this.btnRafraichirStats.TabIndex = 3;
            this.btnRafraichirStats.Text = "Rafraîchir stat";
            this.btnRafraichirStats.UseVisualStyleBackColor = false;
            this.btnRafraichirStats.Click += new System.EventHandler(this.btnRafraichirStats_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.Color.Navy;
            this.btnFermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFermer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFermer.ForeColor = System.Drawing.Color.White;
            this.btnFermer.Location = new System.Drawing.Point(218, 357);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(125, 29);
            this.btnFermer.TabIndex = 4;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // FormStatistiques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(987, 450);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnRafraichirStats);
            this.Controls.Add(this.lblTauxParticipation);
            this.Controls.Add(this.lblNbEvenements);
            this.Controls.Add(this.lblNbUtilisateurs);
            this.Name = "FormStatistiques";
            this.Text = "Statistiques";
            this.ResumeLayout(false);
            this.PerformLayout();
        }


        #endregion

        private Label lblNbUtilisateurs;
        private Label lblNbEvenements;
        private Label lblTauxParticipation;
        private Button btnRafraichirStats;
        private Button btnFermer;
    }
}