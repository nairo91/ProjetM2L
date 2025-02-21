using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppLegeayControles;  // Assure-toi que c'est bien le bon namespace


namespace AppContactEvenementM2Lv5
{
    public partial class FormAdmin : Form
    {
        private int utilisateurConnecteId;


        public FormAdmin()
        {
            InitializeComponent();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            MessageBox.Show("FormAdmin_Load() s'exécute !");
            ChargerUtilisateurs();
            btnStatistiques.Visible = true; // S'assurer qu'il est affiché
        }


        private void ChargerUtilisateurs()
        {
            DataTable utilisateurs = BDD.GetAllUtilisateurs(); // Récupère les utilisateurs depuis la BDD

            // Debug pour voir si les utilisateurs sont récupérés
            //MessageBox.Show($"Nombre d'utilisateurs récupérés : {utilisateurs.Rows.Count}");

            if (utilisateurs.Rows.Count > 0)
            {
                dgvUtilisateurs.AutoGenerateColumns = true; // Active la génération automatique des colonnes
                dgvUtilisateurs.DataSource = utilisateurs; // Associe les données au DataGridView
                dgvUtilisateurs.Refresh();
                dgvUtilisateurs.Update();
                dgvUtilisateurs.Columns["id"].Visible = false; // Masquer l'ID si nécessaire
                dgvUtilisateurs.Columns["nom"].HeaderText = "Nom";
                dgvUtilisateurs.Columns["prenom"].HeaderText = "Prénom";

            }
            else
            {
                MessageBox.Show("Aucun utilisateur trouvé dans la base de données.");
            }
        }


        private void btnSupprimerUtilisateur_Click(object sender, EventArgs e)
        {
            if (dgvUtilisateurs.SelectedRows.Count > 0)
            {
                int utilisateurId = Convert.ToInt32(dgvUtilisateurs.SelectedRows[0].Cells["id"].Value);

                DialogResult confirmation = MessageBox.Show("Confirmer la suppression de l'utilisateur ?", "Confirmation", MessageBoxButtons.YesNo);
                if (confirmation == DialogResult.Yes)
                {
                    BDD.SupprimerUtilisateur(utilisateurId);
                    MessageBox.Show("Utilisateur supprimé avec succès.");
                    ChargerUtilisateurs(); // Rafraîchit la liste des utilisateurs
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un utilisateur à supprimer.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvUtilisateurs.SelectedRows.Count > 0)
            {
                int utilisateurId = Convert.ToInt32(dgvUtilisateurs.SelectedRows[0].Cells["id"].Value);
                string roleActuel = dgvUtilisateurs.SelectedRows[0].Cells["role"].Value.ToString();

                // Vérifie que l'admin ne peut pas se rétrograder lui-même AVANT de modifier le rôle
                if (utilisateurId == utilisateurConnecteId && roleActuel == "admin")
                {
                    MessageBox.Show("Vous ne pouvez pas vous rétrograder vous-même !");
                    return;
                }

                // Changer le rôle (admin <-> user)
                string nouveauRole = roleActuel == "admin" ? "user" : "admin";
                BDD.ChangerRoleUtilisateur(utilisateurId, nouveauRole);

                MessageBox.Show($"Le rôle a été changé en {nouveauRole}.");
                ChargerUtilisateurs(); // Rafraîchit la liste des utilisateurs
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un utilisateur pour changer son rôle.");
            }
        }

        private void btnRafraichir_Click(object sender, EventArgs e)
        {
            ChargerUtilisateurs();
        }

        private void dgvUtilisateurs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnStatistiques_Click(object sender, EventArgs e)
        {
            FormStatistiques formStatistiques = new FormStatistiques();
            formStatistiques.ShowDialog(); // Ouvre la fenêtre en mode modal
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            Form1 formLogin = new Form1();
            formLogin.Show();
            this.Close();
        }
    }
}
