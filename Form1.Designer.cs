namespace AppLegeayControles
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbMail = new System.Windows.Forms.Label();
            this.lbMDP = new System.Windows.Forms.Label();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.tbMDP = new System.Windows.Forms.TextBox();
            this.btConnexion = new System.Windows.Forms.Button();
            this.btInscription = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbMail
            // 
            this.lbMail.AutoSize = true;
            this.lbMail.Font = new System.Drawing.Font("Cambria Math", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMail.Location = new System.Drawing.Point(58, 101);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(75, 84);
            this.lbMail.TabIndex = 0;
            this.lbMail.Text = "Mail :";
            // 
            // lbMDP
            // 
            this.lbMDP.AutoSize = true;
            this.lbMDP.Font = new System.Drawing.Font("Cambria Math", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMDP.Location = new System.Drawing.Point(37, 152);
            this.lbMDP.Name = "lbMDP";
            this.lbMDP.Size = new System.Drawing.Size(136, 84);
            this.lbMDP.TabIndex = 1;
            this.lbMDP.Text = "Mot de passe :";
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(170, 131);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(125, 27);
            this.tbMail.TabIndex = 2;
            // 
            // tbMDP
            // 
            this.tbMDP.Location = new System.Drawing.Point(170, 180);
            this.tbMDP.Name = "tbMDP";
            this.tbMDP.PasswordChar = '*';
            this.tbMDP.Size = new System.Drawing.Size(125, 27);
            this.tbMDP.TabIndex = 3;
            // 
            // btConnexion
            // 
            this.btConnexion.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btConnexion.Location = new System.Drawing.Point(472, 275);
            this.btConnexion.Name = "btConnexion";
            this.btConnexion.Size = new System.Drawing.Size(112, 64);
            this.btConnexion.TabIndex = 4;
            this.btConnexion.Text = "Connexion";
            this.btConnexion.UseVisualStyleBackColor = false;
            this.btConnexion.Click += new System.EventHandler(this.btConnexion_Click_1);
            // 
            // btInscription
            // 
            this.btInscription.BackColor = System.Drawing.Color.LightBlue;
            this.btInscription.Location = new System.Drawing.Point(170, 275);
            this.btInscription.Name = "btInscription";
            this.btInscription.Size = new System.Drawing.Size(125, 64);
            this.btInscription.TabIndex = 5;
            this.btInscription.Text = "Inscription";
            this.btInscription.UseVisualStyleBackColor = false;
            this.btInscription.Click += new System.EventHandler(this.btInscription_Click_1);
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.Brown;
            this.btnQuitter.Location = new System.Drawing.Point(698, 398);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(90, 41);
            this.btnQuitter.TabIndex = 6;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btInscription);
            this.Controls.Add(this.btConnexion);
            this.Controls.Add(this.tbMDP);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.lbMDP);
            this.Controls.Add(this.lbMail);
            this.Name = "Form1";
            this.Text = "Page d\'accueil";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbMail;
        private Label lbMDP;
        private TextBox tbMail;
        private TextBox tbMDP;
        private Button btConnexion;
        private Button btInscription;
        private Button btnQuitter;
    }
}