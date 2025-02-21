namespace AppContactEvenementM2Lv5
{
    partial class FormProfil
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
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbMdp = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbMdp = new System.Windows.Forms.Label();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.lbNvNom = new System.Windows.Forms.Label();
            this.lbNvPrenom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(157, 61);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(194, 27);
            this.tbEmail.TabIndex = 0;
            // 
            // tbMdp
            // 
            this.tbMdp.Location = new System.Drawing.Point(198, 236);
            this.tbMdp.Name = "tbMdp";
            this.tbMdp.Size = new System.Drawing.Size(194, 27);
            this.tbMdp.TabIndex = 1;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(12, 68);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(104, 20);
            this.lbEmail.TabIndex = 2;
            this.lbEmail.Text = "Nouvel Email :";
            // 
            // lbMdp
            // 
            this.lbMdp.AutoSize = true;
            this.lbMdp.Location = new System.Drawing.Point(0, 243);
            this.lbMdp.Name = "lbMdp";
            this.lbMdp.Size = new System.Drawing.Size(168, 20);
            this.lbMdp.TabIndex = 3;
            this.lbMdp.Text = "Nouveau Mot de passe :";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(33, 336);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(187, 60);
            this.btnEnregistrer.TabIndex = 4;
            this.btnEnregistrer.Text = "Mettre a jour";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(157, 119);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(194, 27);
            this.tbNom.TabIndex = 5;
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(157, 178);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(194, 27);
            this.tbPrenom.TabIndex = 6;
            // 
            // lbNvNom
            // 
            this.lbNvNom.AutoSize = true;
            this.lbNvNom.Location = new System.Drawing.Point(12, 126);
            this.lbNvNom.Name = "lbNvNom";
            this.lbNvNom.Size = new System.Drawing.Size(109, 20);
            this.lbNvNom.TabIndex = 7;
            this.lbNvNom.Text = "Nouveau nom :";
            // 
            // lbNvPrenom
            // 
            this.lbNvPrenom.AutoSize = true;
            this.lbNvPrenom.Location = new System.Drawing.Point(12, 185);
            this.lbNvPrenom.Name = "lbNvPrenom";
            this.lbNvPrenom.Size = new System.Drawing.Size(131, 20);
            this.lbNvPrenom.TabIndex = 8;
            this.lbNvPrenom.Text = "Nouveau prenom :";
            // 
            // FormProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbNvPrenom);
            this.Controls.Add(this.lbNvNom);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.lbMdp);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.tbMdp);
            this.Controls.Add(this.tbEmail);
            this.Name = "FormProfil";
            this.Text = "FormProfil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbEmail;
        private TextBox tbMdp;
        private Label lbEmail;
        private Label lbMdp;
        private Button btnEnregistrer;
        private TextBox tbNom;
        private TextBox tbPrenom;
        private Label lbNvNom;
        private Label lbNvPrenom;
    }
}