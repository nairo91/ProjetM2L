namespace AppContactEvenementM2Lv5
{
    partial class FormAdmin
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
            this.dgvUtilisateurs = new System.Windows.Forms.DataGridView();
            this.btnSupprimerUtilisateur = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRafraichir = new System.Windows.Forms.Button();
            this.btnStatistiques = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtilisateurs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUtilisateurs
            // 
            this.dgvUtilisateurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUtilisateurs.Location = new System.Drawing.Point(56, 41);
            this.dgvUtilisateurs.Name = "dgvUtilisateurs";
            this.dgvUtilisateurs.RowHeadersWidth = 51;
            this.dgvUtilisateurs.RowTemplate.Height = 29;
            this.dgvUtilisateurs.Size = new System.Drawing.Size(671, 252);
            this.dgvUtilisateurs.TabIndex = 0;
            this.dgvUtilisateurs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUtilisateurs_CellContentClick);
            // 
            // btnSupprimerUtilisateur
            // 
            this.btnSupprimerUtilisateur.Location = new System.Drawing.Point(180, 326);
            this.btnSupprimerUtilisateur.Name = "btnSupprimerUtilisateur";
            this.btnSupprimerUtilisateur.Size = new System.Drawing.Size(151, 54);
            this.btnSupprimerUtilisateur.TabIndex = 1;
            this.btnSupprimerUtilisateur.Text = "Supprimer";
            this.btnSupprimerUtilisateur.UseVisualStyleBackColor = true;
            this.btnSupprimerUtilisateur.Click += new System.EventHandler(this.btnSupprimerUtilisateur_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 54);
            this.button1.TabIndex = 2;
            this.button1.Text = "Changer de role";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRafraichir
            // 
            this.btnRafraichir.Location = new System.Drawing.Point(351, 326);
            this.btnRafraichir.Name = "btnRafraichir";
            this.btnRafraichir.Size = new System.Drawing.Size(151, 54);
            this.btnRafraichir.TabIndex = 3;
            this.btnRafraichir.Text = "Rafraichir";
            this.btnRafraichir.UseVisualStyleBackColor = true;
            this.btnRafraichir.Click += new System.EventHandler(this.btnRafraichir_Click);
            // 
            // btnStatistiques
            // 
            this.btnStatistiques.Location = new System.Drawing.Point(524, 326);
            this.btnStatistiques.Name = "btnStatistiques";
            this.btnStatistiques.Size = new System.Drawing.Size(151, 54);
            this.btnStatistiques.TabIndex = 4;
            this.btnStatistiques.Text = "Stat";
            this.btnStatistiques.UseVisualStyleBackColor = true;
            this.btnStatistiques.Click += new System.EventHandler(this.btnStatistiques_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(728, 326);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(151, 54);
            this.btnFermer.TabIndex = 5;
            this.btnFermer.Text = "Deconnecter";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1079, 450);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnStatistiques);
            this.Controls.Add(this.btnRafraichir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSupprimerUtilisateur);
            this.Controls.Add(this.dgvUtilisateurs);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtilisateurs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvUtilisateurs;
        private Button btnSupprimerUtilisateur;
        private Button button1;
        private Button btnRafraichir;
        private Button btnStatistiques;
        private Button btnFermer;
    }
}