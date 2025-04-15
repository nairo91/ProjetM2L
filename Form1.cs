using System;
using System.Drawing;
using System.Windows.Forms;
using AppLegeayControles;  // Assure-toi que c'est le bon namespace
using AppContactEvenementM2Lv5;

namespace AppLegeayControles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StyleButtons();
            StyleForm();
            this.AcceptButton = btConnexion;

        }

        private void StyleButtons()
        {
            // Taille et style pour le bouton Connexion
            btConnexion.Size = new Size(250, 50); // Ajuster la taille


            // Taille et style pour le bouton Inscription
            btInscription.Size = new Size(250, 50); // Ajuster la taille

        }

        private void ConfigureButton(Button button, Color normalColor, Color hoverColor)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.BackColor = normalColor;
            button.ForeColor = Color.White;
            button.Font = new Font("Arial", 12, FontStyle.Bold);
            button.MouseEnter += (s, e) => button.BackColor = hoverColor; // Couleur au survol
            button.MouseLeave += (s, e) => button.BackColor = normalColor; // Couleur par défaut
        }

        private void StyleForm()
        {

            //this.BackColor = Color.White; 
            // this.Font = new Font("Segoe UI", 10);
            this.Text = "Mon Application Contact Orian";

            //lbMail.Location = new Point(100, 180);
            //lbMDP.Location = new Point(30, 120);

            lbMail.AutoSize = true;
            this.Controls.Add(lbMail);

          


            tbMail.Width = 250;


            lbMDP.AutoSize = true;

            tbMDP.Width = 250;


           
        }

        // Méthode exécutée lors du clic sur le bouton Connexion
        private void btConnexion_Click(object sender, EventArgs e)
        {
            
        }

        private void tbMail_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btConnexion_Click_1(btConnexion, EventArgs.Empty);
            }
        }

        private void tbMDP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btConnexion_Click_1(btConnexion, EventArgs.Empty);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbMail.KeyDown += new KeyEventHandler(tbMail_KeyDown);
            tbMDP.KeyDown += new KeyEventHandler(tbMDP_KeyDown);
        }

      

        private void tbMail_TextChanged(object sender, EventArgs e)
        {
        }

        private void lbMail_Click(object sender, EventArgs e)
        {

        }

        private void tbMDP_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbMDP_Click(object sender, EventArgs e)
        {

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void btConnexion_Click_1(object sender, EventArgs e)
        {
            string email = tbMail.Text;
            string motDePasse = tbMDP.Text;

            if (!email.Contains("@"))
            {
                MessageBox.Show("Veuillez entrer une adresse e-mail valide.");
                return; // Stoppe l'exécution si l'email est invalide
            }

            bool estConnecte = BDD.ConnexionUtilisateur(email, motDePasse);

            if (estConnecte)
            {
                int utilisateurId = BDD.GetUtilisateurId(email); // Obtenir l'ID de l'utilisateur connecté
                string role = BDD.GetUserRole(email); // Récupérer le rôle de l'utilisateur

                MessageBox.Show($"Utilisateur connecté avec ID : {utilisateurId} et rôle : {role}");

                // Redirection selon le rôle
                if (role == "admin")
                {
                    FormAdmin formAdmin = new FormAdmin();  // Ouvre l'interface Admin
                    formAdmin.Show();
                }
                else
                {
                    FormSelection formSelection = new FormSelection(utilisateurId); // Interface utilisateur standard
                    formSelection.Show();
                }

                this.Hide(); // Cache la fenêtre actuelle
            }
            else
            {
                MessageBox.Show("Email ou mot de passe incorrect.");
            }
        }

        private void btInscription_Click_1(object sender, EventArgs e)
        {
            FormInscription formInscription = new FormInscription();
            formInscription.ShowDialog(); // Ouvre le formulaire d'inscription

        }
    }
}
