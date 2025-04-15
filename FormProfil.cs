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
    public partial class FormProfil : Form
    {
        private int utilisateurId;

        public FormProfil(int id)
        {
            InitializeComponent();
            utilisateurId = id;
            ChargerInfosUtilisateur(); // Remplit les champs avec les infos actuelles
        }

        private void ChargerInfosUtilisateur()
        {
            string[] infosUtilisateur = BDD.GetInfosUtilisateur(utilisateurId);

            if (infosUtilisateur != null && infosUtilisateur.Length == 3)
            {
                tbNom.Text = infosUtilisateur[0]; // Nom
                tbPrenom.Text = infosUtilisateur[1]; // Prénom
                tbEmail.Text = infosUtilisateur[2]; // Email
            }
        }


        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            string nouveauNom = tbNom.Text;
            string nouveauPrenom = tbPrenom.Text;
            string nouvelEmail = tbEmail.Text.Trim();
            string nouveauMdp = tbMdp.Text.Trim();
            bool modificationReussie;

            if (string.IsNullOrWhiteSpace(nouvelEmail))
            {
                MessageBox.Show("L'email ne peut pas être vide.");
                return;
            }

            if (string.IsNullOrWhiteSpace(nouveauMdp))
            {
                // Mise à jour uniquement de l'email
                modificationReussie = BDD.ModifierUtilisateur(utilisateurId, nouveauNom, nouveauPrenom, nouvelEmail, null);
                MessageBox.Show("L'email a été mis à jour. Le mot de passe reste inchangé.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Mise à jour de l'email et du mot de passe
                modificationReussie = BDD.ModifierUtilisateur(utilisateurId, nouveauNom, nouveauPrenom, nouvelEmail, nouveauMdp);

                MessageBox.Show("Profil mis à jour avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (!modificationReussie)
            {
                MessageBox.Show("Erreur lors de la mise à jour.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Close(); // Ferme le formulaire après mise à jour
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
