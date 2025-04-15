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
            this.btnStat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numParticipants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvenements)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNom
            // 
            this.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNom.Location = new System.Drawing.Point(165, 45);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(229, 30);
            this.txtNom.TabIndex = 0;
            this.txtNom.TextChanged += new System.EventHandler(this.txtNom_TextChanged);
            // 
            // txtLieu
            // 
            this.txtLieu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLieu.Location = new System.Drawing.Point(165, 180);
            this.txtLieu.Name = "txtLieu";
            this.txtLieu.Size = new System.Drawing.Size(229, 30);
            this.txtLieu.TabIndex = 1;
            this.txtLieu.TextChanged += new System.EventHandler(this.txtLieu_TextChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Location = new System.Drawing.Point(165, 249);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(229, 49);
            this.txtDescription.TabIndex = 2;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(163, 123);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(231, 30);
            this.dtpDate.TabIndex = 3;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // numParticipants
            // 
            this.numParticipants.Location = new System.Drawing.Point(194, 337);
            this.numParticipants.Name = "numParticipants";
            this.numParticipants.Size = new System.Drawing.Size(150, 30);
            this.numParticipants.TabIndex = 4;
            this.numParticipants.ValueChanged += new System.EventHandler(this.numParticipants_ValueChanged);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.Navy;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(13, 396);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(159, 37);
            this.btnAjouter.TabIndex = 5;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click_1);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.Navy;
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.Location = new System.Drawing.Point(13, 447);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(159, 37);
            this.btnSupprimer.TabIndex = 6;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click_1);
            // 
            // dgvEvenements
            // 
            this.dgvEvenements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvenements.Location = new System.Drawing.Point(408, 109);
            this.dgvEvenements.Name = "dgvEvenements";
            this.dgvEvenements.ReadOnly = true;
            this.dgvEvenements.RowHeadersWidth = 51;
            this.dgvEvenements.RowTemplate.Height = 29;
            this.dgvEvenements.Size = new System.Drawing.Size(712, 368);
            this.dgvEvenements.TabIndex = 7;
            this.dgvEvenements.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEvenements_CellClick);
            this.dgvEvenements.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEvenements_CellContentClick);
            // 
            // btnAfficher
            // 
            this.btnAfficher.BackColor = System.Drawing.Color.Navy;
            this.btnAfficher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAfficher.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAfficher.ForeColor = System.Drawing.Color.White;
            this.btnAfficher.Location = new System.Drawing.Point(1150, 372);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(119, 37);
            this.btnAfficher.TabIndex = 8;
            this.btnAfficher.Text = "Rafraichir";
            this.btnAfficher.UseVisualStyleBackColor = false;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // lbNomEv
            // 
            this.lbNomEv.AutoSize = true;
            this.lbNomEv.Location = new System.Drawing.Point(12, 47);
            this.lbNomEv.Name = "lbNomEv";
            this.lbNomEv.Size = new System.Drawing.Size(147, 23);
            this.lbNomEv.TabIndex = 9;
            this.lbNomEv.Text = "Nom évènement :";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(12, 123);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(145, 23);
            this.lbDate.TabIndex = 10;
            this.lbDate.Text = "Date évènement :";
            // 
            // lbLieu
            // 
            this.lbLieu.AutoSize = true;
            this.lbLieu.Location = new System.Drawing.Point(13, 187);
            this.lbLieu.Name = "lbLieu";
            this.lbLieu.Size = new System.Drawing.Size(50, 23);
            this.lbLieu.TabIndex = 11;
            this.lbLieu.Text = "Lieu :";
            // 
            // lbDesc
            // 
            this.lbDesc.AutoSize = true;
            this.lbDesc.Location = new System.Drawing.Point(12, 251);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(105, 23);
            this.lbDesc.TabIndex = 12;
            this.lbDesc.Text = "Description :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre participants :";
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.Firebrick;
            this.btnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetour.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRetour.ForeColor = System.Drawing.Color.White;
            this.btnRetour.Location = new System.Drawing.Point(1126, 425);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(159, 37);
            this.btnRetour.TabIndex = 14;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.Navy;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModifier.ForeColor = System.Drawing.Color.White;
            this.btnModifier.Location = new System.Drawing.Point(198, 396);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(159, 37);
            this.btnModifier.TabIndex = 15;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnDesinscrire
            // 
            this.btnDesinscrire.BackColor = System.Drawing.Color.Navy;
            this.btnDesinscrire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesinscrire.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDesinscrire.ForeColor = System.Drawing.Color.White;
            this.btnDesinscrire.Location = new System.Drawing.Point(960, 63);
            this.btnDesinscrire.Name = "btnDesinscrire";
            this.btnDesinscrire.Size = new System.Drawing.Size(145, 40);
            this.btnDesinscrire.TabIndex = 17;
            this.btnDesinscrire.Text = "Désinscrire";
            this.btnDesinscrire.UseVisualStyleBackColor = false;
            this.btnDesinscrire.Click += new System.EventHandler(this.btnDesinscrire_Click);
            // 
            // btnInscrire
            // 
            this.btnInscrire.BackColor = System.Drawing.Color.Navy;
            this.btnInscrire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInscrire.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInscrire.ForeColor = System.Drawing.Color.White;
            this.btnInscrire.Location = new System.Drawing.Point(793, 63);
            this.btnInscrire.Name = "btnInscrire";
            this.btnInscrire.Size = new System.Drawing.Size(145, 40);
            this.btnInscrire.TabIndex = 16;
            this.btnInscrire.Text = "S\'inscrire";
            this.btnInscrire.UseVisualStyleBackColor = false;
            this.btnInscrire.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMesEvenements
            // 
            this.btnMesEvenements.BackColor = System.Drawing.Color.Navy;
            this.btnMesEvenements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMesEvenements.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMesEvenements.ForeColor = System.Drawing.Color.White;
            this.btnMesEvenements.Location = new System.Drawing.Point(437, 62);
            this.btnMesEvenements.Name = "btnMesEvenements";
            this.btnMesEvenements.Size = new System.Drawing.Size(157, 39);
            this.btnMesEvenements.TabIndex = 18;
            this.btnMesEvenements.Text = "Mes participations";
            this.btnMesEvenements.UseVisualStyleBackColor = false;
            this.btnMesEvenements.Click += new System.EventHandler(this.btnMesEvenements_Click);
            // 
            // btnEvenementsCrees
            // 
            this.btnEvenementsCrees.BackColor = System.Drawing.Color.Navy;
            this.btnEvenementsCrees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvenementsCrees.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEvenementsCrees.ForeColor = System.Drawing.Color.White;
            this.btnEvenementsCrees.Location = new System.Drawing.Point(622, 63);
            this.btnEvenementsCrees.Name = "btnEvenementsCrees";
            this.btnEvenementsCrees.Size = new System.Drawing.Size(141, 39);
            this.btnEvenementsCrees.TabIndex = 19;
            this.btnEvenementsCrees.Text = "Mes évènements";
            this.btnEvenementsCrees.UseVisualStyleBackColor = false;
            this.btnEvenementsCrees.Click += new System.EventHandler(this.btnEvenementsCrees_Click);
            // 
            // cbFiltre
            // 
            this.cbFiltre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltre.FormattingEnabled = true;
            this.cbFiltre.Items.AddRange(new object[] {
            "Tous",
            "À venir",
            "En cours",
            "Passés"});
            this.cbFiltre.Location = new System.Drawing.Point(1123, 120);
            this.cbFiltre.Name = "cbFiltre";
            this.cbFiltre.Size = new System.Drawing.Size(151, 31);
            this.cbFiltre.TabIndex = 20;
            this.cbFiltre.SelectedIndexChanged += new System.EventHandler(this.cbFiltre_SelectedIndexChanged);
            // 
            // btnStat
            // 
            this.btnStat.BackColor = System.Drawing.Color.Navy;
            this.btnStat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStat.ForeColor = System.Drawing.Color.White;
            this.btnStat.Location = new System.Drawing.Point(1131, 187);
            this.btnStat.Name = "btnStat";
            this.btnStat.Size = new System.Drawing.Size(143, 54);
            this.btnStat.TabIndex = 21;
            this.btnStat.Text = "Statistiques par évènement";
            this.btnStat.UseVisualStyleBackColor = false;
            this.btnStat.Click += new System.EventHandler(this.btnStat_Click);
            // 
            // FormEvenement
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1286, 496);
            this.Controls.Add(this.cbFiltre);
            this.Controls.Add(this.btnStat);
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
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
        private Button btnStat;
    }
}