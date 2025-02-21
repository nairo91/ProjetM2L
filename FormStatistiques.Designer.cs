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
            this.lblNbUtilisateurs.Location = new System.Drawing.Point(36, 49);
            this.lblNbUtilisateurs.Name = "lblNbUtilisateurs";
            this.lblNbUtilisateurs.Size = new System.Drawing.Size(158, 20);
            this.lblNbUtilisateurs.TabIndex = 0;
            this.lblNbUtilisateurs.Text = "Nombre d\'utilisateurs :";
            // 
            // lblNbEvenements
            // 
            this.lblNbEvenements.AutoSize = true;
            this.lblNbEvenements.Location = new System.Drawing.Point(36, 110);
            this.lblNbEvenements.Name = "lblNbEvenements";
            this.lblNbEvenements.Size = new System.Drawing.Size(166, 20);
            this.lblNbEvenements.TabIndex = 1;
            this.lblNbEvenements.Text = "Nombre d\'événements :";
            // 
            // lblTauxParticipation
            // 
            this.lblTauxParticipation.AutoSize = true;
            this.lblTauxParticipation.Location = new System.Drawing.Point(36, 173);
            this.lblTauxParticipation.Name = "lblTauxParticipation";
            this.lblTauxParticipation.Size = new System.Drawing.Size(155, 20);
            this.lblTauxParticipation.TabIndex = 2;
            this.lblTauxParticipation.Text = "Taux de participation :";
            // 
            // btnRafraichirStats
            // 
            this.btnRafraichirStats.Location = new System.Drawing.Point(45, 357);
            this.btnRafraichirStats.Name = "btnRafraichirStats";
            this.btnRafraichirStats.Size = new System.Drawing.Size(125, 29);
            this.btnRafraichirStats.TabIndex = 3;
            this.btnRafraichirStats.Text = "Rafraichir Stat";
            this.btnRafraichirStats.UseVisualStyleBackColor = true;
            this.btnRafraichirStats.Click += new System.EventHandler(this.btnRafraichirStats_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(218, 357);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(125, 29);
            this.btnFermer.TabIndex = 4;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // FormStatistiques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 450);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnRafraichirStats);
            this.Controls.Add(this.lblTauxParticipation);
            this.Controls.Add(this.lblNbEvenements);
            this.Controls.Add(this.lblNbUtilisateurs);
            this.Name = "FormStatistiques";
            this.Text = "FormStatistiques";
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