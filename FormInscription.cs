using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppLegeayControles;

namespace AppContactEvenementM2Lv5
{
    public partial class FormInscription : Form
    {
        public FormInscription()
        {
            InitializeComponent();
        }

        private void tbNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPrenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbMDP_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInscrire_Click(object sender, EventArgs e)
        {
            string nom = tbNom.Text.Trim();
            string prenom = tbPrenom.Text.Trim();
            string email = tbEmail.Text.Trim();
            string motDePasse = tbMDP.Text.Trim();

            // Vérification des champs
            if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(prenom) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(motDePasse))
            {
                MessageBox.Show("Tous les champs sont obligatoires.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Vérification de l'email valide
            if (!email.Contains("@"))
            {
                MessageBox.Show("Veuillez entrer une adresse e-mail valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Inscrire l'utilisateur en base de données
            bool estInscrit = BDD.InscrireUtilisateur(nom, prenom, email, motDePasse);

            if (estInscrit)
            {
                MessageBox.Show("Inscription réussie !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Fermer le formulaire après inscription
            }
            else
            {
                MessageBox.Show("Une erreur s'est produite lors de l'inscription.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
