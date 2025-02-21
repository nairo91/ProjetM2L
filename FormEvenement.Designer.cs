namespace AppLegeayControles
{
    partial class FormEvenement
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
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtLieu = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.numParticipants = new System.Windows.Forms.NumericUpDown();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.dgvEvenements = new System.Windows.Forms.DataGridView();
            this.btnAfficher = new System.Windows.Forms.Button();
            this.lbNomEv = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbLieu = new System.Windows.Forms.Label();
            this.lbDesc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnDesinscrire = new System.Windows.Forms.Button();
            this.btnInscrire = new System.Windows.Forms.Button();
            this.btnMesEvenements = new System.Windows.Forms.Button();
            this.btnEvenementsCrees = new System.Windows.Forms.Button();
            this.cbFiltre = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numParticipants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvenements)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(144, 44);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(155, 27);
            this.txtNom.TabIndex = 0;
            this.txtNom.TextChanged += new System.EventHandler(this.txtNom_TextChanged);
            // 
            // txtLieu
            // 
            this.txtLieu.Location = new System.Drawing.Point(99, 180);
            this.txtLieu.Name = "txtLieu";
            this.txtLieu.Size = new System.Drawing.Size(155, 27);
            this.txtLieu.TabIndex = 1;
            this.txtLieu.TextChanged += new System.EventHandler(this.txtLieu_TextChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(110, 248);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(155, 27);
            this.txtDescription.TabIndex = 2;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(144, 118);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(250, 27);
            this.dtpDate.TabIndex = 3;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // numParticipants
            // 
            this.numParticipants.Location = new System.Drawing.Point(171, 337);
            this.numParticipants.Name = "numParticipants";
            this.numParticipants.Size = new System.Drawing.Size(150, 27);
            this.numParticipants.TabIndex = 4;
            this.numParticipants.ValueChanged += new System.EventHandler(this.numParticipants_ValueChanged);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(13, 396);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(159, 37);
            this.btnAjouter.TabIndex = 5;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click_1);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(106, 447);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(159, 37);
            this.btnSupprimer.TabIndex = 6;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click_1);
            // 
            // dgvEvenements
            // 
            this.dgvEvenements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvenements.Location = new System.Drawing.Point(400, 23);
            this.dgvEvenements.Name = "dgvEvenements";
            this.dgvEvenements.ReadOnly = true;
            this.dgvEvenements.RowHeadersWidth = 51;
            this.dgvEvenements.RowTemplate.Height = 29;
            this.dgvEvenements.Size = new System.Drawing.Size(712, 252);
            this.dgvEvenements.TabIndex = 7;
            this.dgvEvenements.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEvenements_CellClick);
            this.dgvEvenements.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEvenements_CellContentClick);
            // 
            // btnAfficher
            // 
            this.btnAfficher.Location = new System.Drawing.Point(514, 281);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(85, 37);
            this.btnAfficher.TabIndex = 8;
            this.btnAfficher.Text = "Afficher";
            this.btnAfficher.UseVisualStyleBackColor = true;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // lbNomEv
            // 
            this.lbNomEv.AutoSize = true;
            this.lbNomEv.Location = new System.Drawing.Point(12, 47);
            this.lbNomEv.Name = "lbNomEv";
            this.lbNomEv.Size = new System.Drawing.Size(126, 20);
            this.lbNomEv.TabIndex = 9;
            this.lbNomEv.Text = "Nom évènement :";
            this.lbNomEv.Click += new System.EventHandler(this.lbNomEv_Click);
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(12, 123);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(125, 20);
            this.lbDate.TabIndex = 10;
            this.lbDate.Text = "Date évènement :";
            // 
            // lbLieu
            // 
            this.lbLieu.AutoSize = true;
            this.lbLieu.Location = new System.Drawing.Point(13, 187);
            this.lbLieu.Name = "lbLieu";
            this.lbLieu.Size = new System.Drawing.Size(43, 20);
            this.lbLieu.TabIndex = 11;
            this.lbLieu.Text = "Lieu :";
            // 
            // lbDesc
            // 
            this.lbDesc.AutoSize = true;
            this.lbDesc.Location = new System.Drawing.Point(12, 251);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(92, 20);
            this.lbDesc.TabIndex = 12;
            this.lbDesc.Text = "Description :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre participants :";
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.Firebrick;
            this.btnRetour.Location = new System.Drawing.Point(1027, 447);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(159, 37);
            this.btnRetour.TabIndex = 14;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(198, 396);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(159, 37);
            this.btnModifier.TabIndex = 15;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnDesinscrire
            // 
            this.btnDesinscrire.Location = new System.Drawing.Point(844, 281);
            this.btnDesinscrire.Name = "btnDesinscrire";
            this.btnDesinscrire.Size = new System.Drawing.Size(104, 37);
            this.btnDesinscrire.TabIndex = 17;
            this.btnDesinscrire.Text = "Désinscrire";
            this.btnDesinscrire.UseVisualStyleBackColor = true;
            this.btnDesinscrire.Click += new System.EventHandler(this.btnDesinscrire_Click);
            // 
            // btnInscrire
            // 
            this.btnInscrire.Location = new System.Drawing.Point(687, 281);
            this.btnInscrire.Name = "btnInscrire";
            this.btnInscrire.Size = new System.Drawing.Size(93, 37);
            this.btnInscrire.TabIndex = 16;
            this.btnInscrire.Text = "S\'inscrire";
            this.btnInscrire.UseVisualStyleBackColor = true;
            this.btnInscrire.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMesEvenements
            // 
            this.btnMesEvenements.Location = new System.Drawing.Point(571, 391);
            this.btnMesEvenements.Name = "btnMesEvenements";
            this.btnMesEvenements.Size = new System.Drawing.Size(141, 42);
            this.btnMesEvenements.TabIndex = 18;
            this.btnMesEvenements.Text = "Mes participations";
            this.btnMesEvenements.UseVisualStyleBackColor = true;
            this.btnMesEvenements.Click += new System.EventHandler(this.btnMesEvenements_Click);
            // 
            // btnEvenementsCrees
            // 
            this.btnEvenementsCrees.Location = new System.Drawing.Point(753, 391);
            this.btnEvenementsCrees.Name = "btnEvenementsCrees";
            this.btnEvenementsCrees.Size = new System.Drawing.Size(141, 42);
            this.btnEvenementsCrees.TabIndex = 19;
            this.btnEvenementsCrees.Text = "Mes évènements";
            this.btnEvenementsCrees.UseVisualStyleBackColor = true;
            this.btnEvenementsCrees.Click += new System.EventHandler(this.btnEvenementsCrees_Click);
            // 
            // cbFiltre
            // 
            this.cbFiltre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltre.FormattingEnabled = true;
            this.cbFiltre.Items.AddRange(new object[] {
            "Tous",
            "A venir",
            "Passés"});
            this.cbFiltre.Location = new System.Drawing.Point(1118, 39);
            this.cbFiltre.Name = "cbFiltre";
            this.cbFiltre.Size = new System.Drawing.Size(151, 28);
            this.cbFiltre.TabIndex = 20;
            this.cbFiltre.SelectedIndexChanged += new System.EventHandler(this.cbFiltre_SelectedIndexChanged);
            // 
            // FormEvenement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1286, 496);
            this.Controls.Add(this.cbFiltre);
            this.Controls.Add(this.btnEvenementsCrees);
            this.Controls.Add(this.btnMesEvenements);
            this.Controls.Add(this.btnDesinscrire);
            this.Controls.Add(this.btnInscrire);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbDesc);
            this.Controls.Add(this.lbLieu);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbNomEv);
            this.Controls.Add(this.btnAfficher);
            this.Controls.Add(this.dgvEvenements);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.numParticipants);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtLieu);
            this.Controls.Add(this.txtNom);
            this.Name = "FormEvenement";
            this.Text = "Les évènements";
            ((System.ComponentModel.ISupportInitialize)(this.numParticipants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvenements)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNom;
        private TextBox txtLieu;
        private TextBox txtDescription;
        private DateTimePicker dtpDate;
        private NumericUpDown numParticipants;
        private Button btnAjouter;
        private Button btnSupprimer;
        private DataGridView dgvEvenements;
        private Button btnAfficher;
        private Label lbNomEv;
        private Label lbDate;
        private Label lbLieu;
        private Label lbDesc;
        private Label label1;
        private Button btnRetour;
        private Button btnModifier;
        private Button btnDesinscrire;
        private Button btnInscrire;
        private Button btnMesEvenements;
        private Button btnEvenementsCrees;
        private ComboBox cbFiltre;
    }
}