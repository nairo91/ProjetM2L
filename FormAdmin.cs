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
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            ChargerUtilisateurs();
        }


        private void ChargerUtilisateurs()
        {
            dgvUtilisateurs.DataSource = BDD.GetAllUtilisateurs(); // Charge les utilisateurs depuis la base de données
            dgvUtilisateurs.Columns["id"].Visible = false; // Masquer la colonne ID si nécessaire
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
    }
}
