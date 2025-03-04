namespace AppContactEvenementM2Lv5
{
    partial class FormInscription
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
            this.lbNom = new System.Windows.Forms.Label();
            this.lbPrenom = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbMDP = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbMDP = new System.Windows.Forms.TextBox();
            this.btnInscrire = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNom.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbNom.Location = new System.Drawing.Point(30, 45);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(57, 23);
            this.lbNom.TabIndex = 0;
            this.lbNom.Text = "Nom :";
            // 
            // lbPrenom
            // 
            this.lbPrenom.AutoSize = true;
            this.lbPrenom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPrenom.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbPrenom.Location = new System.Drawing.Point(30, 106);
            this.lbPrenom.Name = "lbPrenom";
            this.lbPrenom.Size = new System.Drawing.Size(79, 23);
            this.lbPrenom.TabIndex = 1;
            this.lbPrenom.Text = "Prenom :";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEmail.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbEmail.Location = new System.Drawing.Point(30, 180);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(60, 23);
            this.lbEmail.TabIndex = 2;
            this.lbEmail.Text = "Email :";
            // 
            // lbMDP
            // 
            this.lbMDP.AutoSize = true;
            this.lbMDP.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMDP.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbMDP.Location = new System.Drawing.Point(30, 245);
            this.lbMDP.Name = "lbMDP";
            this.lbMDP.Size = new System.Drawing.Size(121, 23);
            this.lbMDP.TabIndex = 3;
            this.lbMDP.Text = "Mot de passe :";
            // 
            // tbNom
            // 
            this.tbNom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNom.Location = new System.Drawing.Point(106, 42);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(189, 30);
            this.tbNom.TabIndex = 4;
            this.tbNom.TextChanged += new System.EventHandler(this.tbNom_TextChanged);
            // 
            // tbPrenom
            // 
            this.tbPrenom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPrenom.Location = new System.Drawing.Point(106, 103);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(189, 30);
            this.tbPrenom.TabIndex = 5;
            this.tbPrenom.TextChanged += new System.EventHandler(this.tbPrenom_TextChanged);
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbEmail.Location = new System.Drawing.Point(106, 173);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(189, 30);
            this.tbEmail.TabIndex = 6;
            this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            // 
            // tbMDP
            // 
            this.tbMDP.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbMDP.Location = new System.Drawing.Point(159, 242);
            this.tbMDP.Name = "tbMDP";
            this.tbMDP.Size = new System.Drawing.Size(189, 30);
            this.tbMDP.TabIndex = 7;
            this.tbMDP.TextChanged += new System.EventHandler(this.tbMDP_TextChanged);
            // 
            // btnInscrire
            // 
            this.btnInscrire.BackColor = System.Drawing.Color.Navy;
            this.btnInscrire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInscrire.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInscrire.ForeColor = System.Drawing.Color.White;
            this.btnInscrire.Location = new System.Drawing.Point(139, 351);
            this.btnInscrire.Name = "btnInscrire";
            this.btnInscrire.Size = new System.Drawing.Size(139, 44);
            this.btnInscrire.TabIndex = 8;
            this.btnInscrire.Text = "S\'inscrire";
            this.btnInscrire.UseVisualStyleBackColor = false;
            this.btnInscrire.Click += new System.EventHandler(this.btnInscrire_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.Navy;
            this.btnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetour.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRetour.ForeColor = System.Drawing.Color.White;
            this.btnRetour.Location = new System.Drawing.Point(389, 351);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(140, 44);
            this.btnRetour.TabIndex = 9;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // FormInscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnInscrire);
            this.Controls.Add(this.tbMDP);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.lbMDP);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbPrenom);
            this.Controls.Add(this.lbNom);
            this.Name = "FormInscription";
            this.Text = "FormInscription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbNom;
        private Label lbPrenom;
        private Label lbEmail;
        private Label lbMDP;
        private TextBox tbNom;
        private TextBox tbPrenom;
        private TextBox tbEmail;
        private TextBox tbMDP;
        private Button btnInscrire;
        private Button btnRetour;
    }
}