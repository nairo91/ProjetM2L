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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvUtilisateurs = new System.Windows.Forms.DataGridView();
            this.btnSupprimerUtilisateur = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRafraichir = new System.Windows.Forms.Button();
            this.btnStatistiques = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            this.txtNewRole = new System.Windows.Forms.TextBox();
            this.btnAjouterRole = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtilisateurs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUtilisateurs
            // 
            this.dgvUtilisateurs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUtilisateurs.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvUtilisateurs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUtilisateurs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUtilisateurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUtilisateurs.EnableHeadersVisualStyles = false;
            this.dgvUtilisateurs.GridColor = System.Drawing.Color.LightGray;
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
            this.btnSupprimerUtilisateur.BackColor = System.Drawing.Color.Navy;
            this.btnSupprimerUtilisateur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimerUtilisateur.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSupprimerUtilisateur.ForeColor = System.Drawing.Color.White;
            this.btnSupprimerUtilisateur.Location = new System.Drawing.Point(180, 326);
            this.btnSupprimerUtilisateur.Name = "btnSupprimerUtilisateur";
            this.btnSupprimerUtilisateur.Size = new System.Drawing.Size(151, 54);
            this.btnSupprimerUtilisateur.TabIndex = 1;
            this.btnSupprimerUtilisateur.Text = "Supprimer";
            this.btnSupprimerUtilisateur.UseVisualStyleBackColor = false;
            this.btnSupprimerUtilisateur.Click += new System.EventHandler(this.btnSupprimerUtilisateur_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 54);
            this.button1.TabIndex = 2;
            this.button1.Text = "Changer de role";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRafraichir
            // 
            this.btnRafraichir.BackColor = System.Drawing.Color.Navy;
            this.btnRafraichir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRafraichir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRafraichir.ForeColor = System.Drawing.Color.White;
            this.btnRafraichir.Location = new System.Drawing.Point(351, 326);
            this.btnRafraichir.Name = "btnRafraichir";
            this.btnRafraichir.Size = new System.Drawing.Size(151, 54);
            this.btnRafraichir.TabIndex = 3;
            this.btnRafraichir.Text = "Rafraichir";
            this.btnRafraichir.UseVisualStyleBackColor = false;
            this.btnRafraichir.Click += new System.EventHandler(this.btnRafraichir_Click);
            // 
            // btnStatistiques
            // 
            this.btnStatistiques.BackColor = System.Drawing.Color.Navy;
            this.btnStatistiques.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistiques.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStatistiques.ForeColor = System.Drawing.Color.White;
            this.btnStatistiques.Location = new System.Drawing.Point(524, 326);
            this.btnStatistiques.Name = "btnStatistiques";
            this.btnStatistiques.Size = new System.Drawing.Size(151, 54);
            this.btnStatistiques.TabIndex = 4;
            this.btnStatistiques.Text = "Stat";
            this.btnStatistiques.UseVisualStyleBackColor = false;
            this.btnStatistiques.Click += new System.EventHandler(this.btnStatistiques_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.Color.Firebrick;
            this.btnFermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFermer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFermer.ForeColor = System.Drawing.Color.White;
            this.btnFermer.Location = new System.Drawing.Point(728, 326);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(151, 54);
            this.btnFermer.TabIndex = 5;
            this.btnFermer.Text = "Deconnecter";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // cmbRoles
            // 
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Location = new System.Drawing.Point(742, 41);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(151, 28);
            this.cmbRoles.TabIndex = 6;
            // 
            // txtNewRole
            // 
            this.txtNewRole.Location = new System.Drawing.Point(742, 197);
            this.txtNewRole.Name = "txtNewRole";
            this.txtNewRole.Size = new System.Drawing.Size(125, 27);
            this.txtNewRole.TabIndex = 7;
            // 
            // btnAjouterRole
            // 
            this.btnAjouterRole.Location = new System.Drawing.Point(742, 242);
            this.btnAjouterRole.Name = "btnAjouterRole";
            this.btnAjouterRole.Size = new System.Drawing.Size(125, 29);
            this.btnAjouterRole.TabIndex = 8;
            this.btnAjouterRole.Text = "Ajouter rôle";
            this.btnAjouterRole.UseVisualStyleBackColor = true;
            this.btnAjouterRole.Click += new System.EventHandler(this.btnAjouterRole_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1079, 450);
            this.Controls.Add(this.btnAjouterRole);
            this.Controls.Add(this.txtNewRole);
            this.Controls.Add(this.cmbRoles);
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
            this.PerformLayout();

        }


        #endregion

        private DataGridView dgvUtilisateurs;
        private Button btnSupprimerUtilisateur;
        private Button button1;
        private Button btnRafraichir;
        private Button btnStatistiques;
        private Button btnFermer;
        private ComboBox cmbRoles;
        private TextBox txtNewRole;
        private Button btnAjouterRole;
    }
}