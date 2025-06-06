﻿namespace AppLegeayControles
{
    partial class FormSelection
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
            this.btnContacts = new System.Windows.Forms.Button();
            this.btnEvenements = new System.Windows.Forms.Button();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.btnProfil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnContacts
            // 
            this.btnContacts.BackColor = System.Drawing.Color.Navy;
            this.btnContacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContacts.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnContacts.ForeColor = System.Drawing.Color.White;
            this.btnContacts.Location = new System.Drawing.Point(12, 3);
            this.btnContacts.Name = "btnContacts";
            this.btnContacts.Size = new System.Drawing.Size(291, 141);
            this.btnContacts.TabIndex = 0;
            this.btnContacts.Text = "Contact";
            this.btnContacts.UseVisualStyleBackColor = false;
            this.btnContacts.Visible = false;
            this.btnContacts.Click += new System.EventHandler(this.btnContacts_Click);
            // 
            // btnEvenements
            // 
            this.btnEvenements.BackColor = System.Drawing.Color.Navy;
            this.btnEvenements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvenements.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEvenements.ForeColor = System.Drawing.Color.White;
            this.btnEvenements.Location = new System.Drawing.Point(233, 159);
            this.btnEvenements.Name = "btnEvenements";
            this.btnEvenements.Size = new System.Drawing.Size(291, 141);
            this.btnEvenements.TabIndex = 1;
            this.btnEvenements.Text = "Evenement";
            this.btnEvenements.UseVisualStyleBackColor = false;
            this.btnEvenements.Click += new System.EventHandler(this.btnEvenements_Click);
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.BackColor = System.Drawing.Color.Firebrick;
            this.btnDeconnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeconnexion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeconnexion.ForeColor = System.Drawing.Color.White;
            this.btnDeconnexion.Location = new System.Drawing.Point(445, 336);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(167, 87);
            this.btnDeconnexion.TabIndex = 2;
            this.btnDeconnexion.Text = "Deconnexion";
            this.btnDeconnexion.UseVisualStyleBackColor = false;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
            // 
            // btnProfil
            // 
            this.btnProfil.BackColor = System.Drawing.Color.Navy;
            this.btnProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfil.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProfil.ForeColor = System.Drawing.Color.White;
            this.btnProfil.Location = new System.Drawing.Point(152, 336);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Size = new System.Drawing.Size(167, 87);
            this.btnProfil.TabIndex = 3;
            this.btnProfil.Text = "Mettre a jour info";
            this.btnProfil.UseVisualStyleBackColor = false;
            this.btnProfil.Click += new System.EventHandler(this.btnProfil_Click);
            // 
            // FormSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProfil);
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.btnEvenements);
            this.Controls.Add(this.btnContacts);
            this.Name = "FormSelection";
            this.Text = "Choix de gestion ";
            this.ResumeLayout(false);

        }


        #endregion

        private Button btnContacts;
        private Button btnEvenements;
        private Button btnDeconnexion;
        private Button btnProfil;
    }
}