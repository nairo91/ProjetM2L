namespace AppLegeayControles
{
    partial class Form2
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
            this.btnAddContact = new System.Windows.Forms.Button();
            this.btnDelContact = new System.Windows.Forms.Button();
            this.btnModifierContact = new System.Windows.Forms.Button();
            this.btnAfficherContact = new System.Windows.Forms.Button();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbNom = new System.Windows.Forms.Label();
            this.lbNumero = new System.Windows.Forms.Label();
            this.lbMail = new System.Windows.Forms.Label();
            this.lbAdresse = new System.Windows.Forms.Label();
            this.btnRetour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddContact
            // 
            this.btnAddContact.Location = new System.Drawing.Point(34, 353);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(171, 71);
            this.btnAddContact.TabIndex = 0;
            this.btnAddContact.Text = "Ajouter contact";
            this.btnAddContact.UseVisualStyleBackColor = true;
            this.btnAddContact.Click += new System.EventHandler(this.btnAddContact_Click_1);
            // 
            // btnDelContact
            // 
            this.btnDelContact.Location = new System.Drawing.Point(474, 353);
            this.btnDelContact.Name = "btnDelContact";
            this.btnDelContact.Size = new System.Drawing.Size(167, 71);
            this.btnDelContact.TabIndex = 1;
            this.btnDelContact.Text = "Supprimer contact";
            this.btnDelContact.UseVisualStyleBackColor = true;
            this.btnDelContact.Click += new System.EventHandler(this.btnDelContact_Click_1);
            // 
            // btnModifierContact
            // 
            this.btnModifierContact.Location = new System.Drawing.Point(262, 353);
            this.btnModifierContact.Name = "btnModifierContact";
            this.btnModifierContact.Size = new System.Drawing.Size(167, 71);
            this.btnModifierContact.TabIndex = 2;
            this.btnModifierContact.Text = "Modifier contact";
            this.btnModifierContact.UseVisualStyleBackColor = true;
            this.btnModifierContact.Click += new System.EventHandler(this.btnModifierContact_Click_1);
            // 
            // btnAfficherContact
            // 
            this.btnAfficherContact.Location = new System.Drawing.Point(533, 277);
            this.btnAfficherContact.Name = "btnAfficherContact";
            this.btnAfficherContact.Size = new System.Drawing.Size(153, 29);
            this.btnAfficherContact.TabIndex = 3;
            this.btnAfficherContact.Text = "Afficher contact";
            this.btnAfficherContact.UseVisualStyleBackColor = true;
            this.btnAfficherContact.Click += new System.EventHandler(this.btnAfficherContact_Click_1);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(82, 52);
            this.txtNom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(171, 27);
            this.txtNom.TabIndex = 4;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(82, 156);
            this.txtTelephone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(171, 27);
            this.txtTelephone.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(82, 225);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(171, 27);
            this.txtEmail.TabIndex = 6;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(82, 292);
            this.txtAdresse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(171, 27);
            this.txtAdresse.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(344, 52);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(600, 200);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Location = new System.Drawing.Point(14, 56);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(49, 20);
            this.lbNom.TabIndex = 9;
            this.lbNom.Text = "Nom :";
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Location = new System.Drawing.Point(-1, 160);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(85, 20);
            this.lbNumero.TabIndex = 10;
            this.lbNumero.Text = "Téléphone :";
            // 
            // lbMail
            // 
            this.lbMail.AutoSize = true;
            this.lbMail.Location = new System.Drawing.Point(14, 236);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(45, 20);
            this.lbMail.TabIndex = 11;
            this.lbMail.Text = "Mail :";
            // 
            // lbAdresse
            // 
            this.lbAdresse.AutoSize = true;
            this.lbAdresse.Location = new System.Drawing.Point(14, 303);
            this.lbAdresse.Name = "lbAdresse";
            this.lbAdresse.Size = new System.Drawing.Size(68, 20);
            this.lbAdresse.TabIndex = 12;
            this.lbAdresse.Text = "Adresse :";
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.Firebrick;
            this.btnRetour.Location = new System.Drawing.Point(661, 393);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(127, 31);
            this.btnRetour.TabIndex = 13;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(956, 451);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.lbAdresse);
            this.Controls.Add(this.lbMail);
            this.Controls.Add(this.lbNumero);
            this.Controls.Add(this.lbNom);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.btnAfficherContact);
            this.Controls.Add(this.btnModifierContact);
            this.Controls.Add(this.btnDelContact);
            this.Controls.Add(this.btnAddContact);
            this.Name = "Form2";
            this.Text = "Contact";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAddContact;
        private Button btnDelContact;
        private Button btnModifierContact;
        private Button btnAfficherContact;
        private TextBox txtNom;
        private TextBox txtTelephone;
        private TextBox txtEmail;
        private TextBox txtAdresse;
        private DataGridView dataGridView1;
        private Label lbNom;
        private Label lbNumero;
        private Label lbMail;
        private Label lbAdresse;
        private Button btnRetour;
    }
}