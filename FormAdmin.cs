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
            // InitialiserRoles();
         
            ChargerUtilisateurs();
            ChargerRoles();
            btnStatistiques.Visible = true; // S'assurer qu'il est affiché
        }

        private void InitialiserRoles()
        {
            cmbRoles.Items.Clear();
            cmbRoles.Items.Add("user");
            cmbRoles.Items.Add("admin");
            // Ajoute ici les rôles que tu veux voir par défaut
            cmbRoles.SelectedIndex = 0; // Sélectionne le 1er rôle par défaut
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
                // Récupère l'ID de l'utilisateur sélectionné dans la DataGridView
                int utilisateurId = Convert.ToInt32(dgvUtilisateurs.SelectedRows[0].Cells["id"].Value);
                // Rôle actuel en base (pour la vérification)
                string roleActuel = dgvUtilisateurs.SelectedRows[0].Cells["role"].Value.ToString();

                // Vérifie d'abord si un rôle est bien sélectionné dans la ComboBox
                if (cmbRoles.SelectedItem == null)
                {
                    MessageBox.Show("Veuillez sélectionner un rôle dans la liste.");
                    return;
                }
                // Récupère le nouveau rôle choisi dans la ComboBox
                string nouveauRole = cmbRoles.SelectedItem.ToString();

                // Vérifie que l'admin connecté ne peut pas se rétrograder lui-même
                // c'est-à-dire : si je suis l'utilisateur en question, que je suis admin
                // et que je tente de passer à un rôle différent d'admin.
                if (utilisateurId == utilisateurConnecteId && roleActuel == "admin" && nouveauRole != "admin")
                {
                    MessageBox.Show("Vous ne pouvez pas vous rétrograder vous-même !");
                    return;
                }

                // Change le rôle en base via la méthode existante
                bool success = BDD.ChangerRoleUtilisateur(utilisateurId, nouveauRole);
                if (success)
                {
                    MessageBox.Show($"Le rôle a été changé en {nouveauRole}.");
                    ChargerUtilisateurs(); // Rafraîchit la liste pour voir le nouveau rôle
                }
                else
                {
                    MessageBox.Show("Erreur lors de l'assignation du rôle.");
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un utilisateur pour changer son rôle.");
            }
        }

        private void btnRafraichir_Click(object sender, EventArgs e)
        {
            ChargerUtilisateurs();
            ChargerRoles();
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

        private void btnAjouterRole_Click(object sender, EventArgs e)
        {
            string nouveauRole = txtNewRole.Text.Trim();
            if (!string.IsNullOrEmpty(nouveauRole))
            {
                // Vérifie de façon insensible à la casse si le rôle existe déjà
                bool existeDeja = cmbRoles.Items.Cast<string>()
                    .Any(r => r.Equals(nouveauRole, StringComparison.OrdinalIgnoreCase));

                if (!existeDeja)
                {
                    // Récupère la chaîne de rôles actuelle dans les Settings
                    string rolesStr = Properties.Settings.Default.CustomRoles;
                    List<string> rolesList = new List<string>();
                    if (!string.IsNullOrEmpty(rolesStr))
                    {
                        rolesList = rolesStr.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                            .Select(r => r.Trim())
                                            .ToList();
                    }
                    // Ajoute le nouveau rôle (s'il n'existe pas déjà)
                    rolesList.Add(nouveauRole);
                    // Met à jour les Settings
                    Properties.Settings.Default.CustomRoles = string.Join(",", rolesList);
                    Properties.Settings.Default.Save();

                    // Recharge la ComboBox avec la liste mise à jour
                    ChargerRoles();
                    MessageBox.Show($"Le rôle '{nouveauRole}' a été ajouté.", "Rôle ajouté", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNewRole.Clear();
                }
                else
                {
                    MessageBox.Show("Ce rôle existe déjà.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Veuillez entrer un nom de rôle valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChargerRoles()
        {
            cmbRoles.Items.Clear();
            // Récupère la chaîne de rôles stockée dans les Settings
            string rolesStr = Properties.Settings.Default.CustomRoles;

            if (!string.IsNullOrEmpty(rolesStr))
            {
                // 1. Découpe la chaîne, 2. Trim chaque rôle, 3. Évite doublons avec Distinct
                var roles = rolesStr
                    .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(r => r.Trim())
                    .Where(r => !string.IsNullOrEmpty(r))
                    .Distinct(StringComparer.OrdinalIgnoreCase)
                    .ToList();

                // (Optionnel) Réécrit la liste nettoyée dans les Settings pour enlever définitivement les doublons
                Properties.Settings.Default.CustomRoles = string.Join(",", roles);
                Properties.Settings.Default.Save();

                // Ajoute chaque rôle dans la ComboBox
                foreach (string role in roles)
                {
                    cmbRoles.Items.Add(role);
                }
            }

            if (cmbRoles.Items.Count > 0)
                cmbRoles.SelectedIndex = 0;
        }

    }
}
