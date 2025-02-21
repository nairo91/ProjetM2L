using AppContactEvenementM2Lv5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLegeayControles
{
    public partial class FormEvenement : Form
    {
        private EvenementDAO evenementDAO = new EvenementDAO();
        private int utilisateurConnecteId;

        public FormEvenement(int utilisateurId)
        {
            InitializeComponent();
            utilisateurConnecteId = utilisateurId;


            cbFiltre.SelectedIndex = 0; // ✅ Sélectionner "Tous" par défaut
            cbFiltre.SelectedIndexChanged += cbFiltre_SelectedIndexChanged; // ✅ Détecter les changements
        }


        // Charger les événements dans le DataGridView
        // Charger les événements dans le DataGridView
        private void ChargerEvenements(string filtre = "Tous")
        {
            // Récupère tous les événements
            List<Evenement> evenements = evenementDAO.ObtenirEvenements();

            // Trie les événements par date (du plus récent au plus ancien)
            evenements = evenements.OrderBy(e => e.Date).ToList();

            // 🔥 Correction des filtres 🔥
            DateTime aujourdHui = DateTime.Today; // Date actuelle sans heure

            if (filtre == "À venir")
            {
                // ✅ Filtre les événements STRICTEMENT après aujourd'hui
                evenements = evenements.Where(e => e.Date >= aujourdHui.AddDays(1)).ToList();
            }
            else if (filtre == "En cours")
            {
                // ✅ Filtre les événements qui ont LIEU AUJOURD'HUI
                evenements = evenements.Where(e => e.Date.Date == aujourdHui).ToList();
            }
            else if (filtre == "Passés")
            {
                // ✅ Filtre les événements STRICTEMENT avant aujourd'hui
                evenements = evenements.Where(e => e.Date.Date < aujourdHui).ToList();
            }

            // Affecte les données filtrées et triées au DataGridView
            dgvEvenements.DataSource = evenements;

            // Vérifie si la colonne "NombreParticipants" existe déjà, sinon l'ajouter
            if (!dgvEvenements.Columns.Contains("NombreParticipants"))
            {
                dgvEvenements.Columns.Add("NombreParticipants", "Participants");
            }

            // Met à jour la colonne "NombreParticipants"
            foreach (DataGridViewRow row in dgvEvenements.Rows)
            {
                if (row.Cells["Id"].Value != null)
                {
                    int evenementId = Convert.ToInt32(row.Cells["Id"].Value);
                    row.Cells["NombreParticipants"].Value = evenementDAO.NombreParticipants(evenementId);
                }
            }

            // Masquer l'ID et ajuster la taille des colonnes
            dgvEvenements.Columns["Id"].Visible = false;
            dgvEvenements.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }












        // Nettoyer les champs après ajout
        private void NettoyerChamps()
        {
            txtNom.Clear();
            dtpDate.Value = DateTime.Now;
            txtLieu.Clear();
            txtDescription.Clear();
            numParticipants.Value = 0;
        }

        private void dgvEvenements_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtLieu_TextChanged(object sender, EventArgs e)
        {

        }

        private void numParticipants_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNom.Text) || string.IsNullOrWhiteSpace(txtLieu.Text))
            {
                MessageBox.Show("Veuillez remplir les champs obligatoires (Nom et Lieu).", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Evenement evt = new Evenement
            {
                Nom = txtNom.Text,
                Date = dtpDate.Value,
                Lieu = txtLieu.Text,
                Description = txtDescription.Text,
                NbMaxParticipants = (int)numParticipants.Value
            };

            // Ajoute l'événement et INSCRIT AUTOMATIQUEMENT le créateur
            evenementDAO.AjouterEvenement(evt, utilisateurConnecteId);

            MessageBox.Show("Événement ajouté avec succès et vous y êtes inscrit automatiquement !");
            ChargerEvenements();
            NettoyerChamps();
        }

        private void btnSupprimer_Click_1(object sender, EventArgs e)
        {
            if (dgvEvenements.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvEvenements.SelectedRows[0].Cells["Id"].Value);

                bool suppression = evenementDAO.SupprimerEvenement(id, utilisateurConnecteId);
                if (suppression)
                {
                    MessageBox.Show("Événement supprimé avec succès !");
                    ChargerEvenements();
                }
                else
                {
                    MessageBox.Show("La suppression a échoué. Vérifiez que vous êtes bien le créateur de l'événement.");
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un événement à supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnAfficher_Click(object sender, EventArgs e)
        {
            ChargerEvenements();
            MessageBox.Show("Liste des événements chargée avec succès.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void lbNomEv_Click(object sender, EventArgs e)
        {

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            FormSelection formSelection = new FormSelection(utilisateurConnecteId);
            formSelection.Show();
            this.Close(); // Ferme la fenêtre actuelle
        }

        private void dgvEvenements_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Récupère la ligne sélectionnée
                DataGridViewRow selectedRow = dgvEvenements.Rows[e.RowIndex];

                // Remplit les TextBox avec les informations de l'événement sélectionné
                txtNom.Text = selectedRow.Cells["nom"].Value?.ToString() ?? "";
                dtpDate.Value = Convert.ToDateTime(selectedRow.Cells["date"].Value);
                txtLieu.Text = selectedRow.Cells["lieu"].Value?.ToString() ?? "";
                txtDescription.Text = selectedRow.Cells["description"].Value?.ToString() ?? "";
                numParticipants.Value = selectedRow.Cells["NbMaxParticipants"].Value != DBNull.Value
    ? Convert.ToInt32(selectedRow.Cells["NbMaxParticipants"].Value)
    : 0;


                // Afficher un message pour confirmer la sélection
               // MessageBox.Show($"Événement sélectionné : {txtNom.Text}, {dtpDate.Value}, {txtLieu.Text}, {txtDescription.Text}");
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvEvenements.SelectedRows.Count > 0)
            {
                // Récupérer l'ID de l'événement sélectionné
                int evenementId = Convert.ToInt32(dgvEvenements.SelectedRows[0].Cells["Id"].Value);

                // Vérifier si l'utilisateur connecté est bien le créateur AVANT d'essayer de modifier
                if (!evenementDAO.EstCreateurEvenement(evenementId, utilisateurConnecteId))
                {
                    MessageBox.Show("Vous ne pouvez modifier que vos propres événements.");
                    return;
                }

                // Récupérer les nouvelles valeurs depuis les champs
                string nouveauNom = txtNom.Text;
                DateTime nouvelleDate = dtpDate.Value;
                string nouveauLieu = txtLieu.Text;
                string nouvelleDescription = txtDescription.Text;
                int? nouveauNbMaxParticipants = numParticipants.Value > 0 ? (int)numParticipants.Value : (int?)null;

                // Effectuer la mise à jour
                bool modification = evenementDAO.ModifierEvenement(
                    evenementId, utilisateurConnecteId,
                    nouveauNom, nouvelleDate, nouveauLieu, nouvelleDescription, nouveauNbMaxParticipants
                );

                if (modification)
                {
                    MessageBox.Show("Événement modifié avec succès !");
                    ChargerEvenements();
                }
                else
                {
                    MessageBox.Show("La modification a échoué. Vérifiez que vous êtes bien le créateur de l'événement.");
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un événement à modifier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvEvenements.SelectedRows.Count > 0)
            {
                int evenementId = Convert.ToInt32(dgvEvenements.SelectedRows[0].Cells["Id"].Value);
                if (evenementDAO.EstInscrit(utilisateurConnecteId, evenementId))
                {
                    MessageBox.Show("Vous êtes déjà inscrit à cet événement !");
                    return;
                }

                bool inscrit = evenementDAO.InscrireUtilisateur(utilisateurConnecteId, evenementId);
                if (inscrit)
                {
                    MessageBox.Show("Inscription réussie !");
                    ChargerEvenements();
                }
                else
                {
                    MessageBox.Show("Erreur lors de l'inscription.");
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un événement.");
            }
        }

        private void btnDesinscrire_Click(object sender, EventArgs e)
        {
            if (dgvEvenements.SelectedRows.Count > 0)
            {
                int evenementId = Convert.ToInt32(dgvEvenements.SelectedRows[0].Cells["Id"].Value);
                if (!evenementDAO.EstInscrit(utilisateurConnecteId, evenementId))
                {
                    MessageBox.Show("Vous n'êtes pas inscrit à cet événement !");
                    return;
                }

                bool desinscrit = evenementDAO.DesinscrireUtilisateur(utilisateurConnecteId, evenementId);
                if (desinscrit)
                {
                    MessageBox.Show("Désinscription réussie !");
                    ChargerEvenements();
                }
                else
                {
                    MessageBox.Show("Erreur lors de la désinscription.");
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un événement.");
            }
        }

        private void btnMesEvenements_Click(object sender, EventArgs e)
        {
            dgvEvenements.DataSource = evenementDAO.ObtenirMesEvenements(utilisateurConnecteId);

        }

        private void btnEvenementsCrees_Click(object sender, EventArgs e)
        {
            dgvEvenements.DataSource = evenementDAO.ObtenirEvenementsCrees(utilisateurConnecteId);

        }

        private void cbFiltre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFiltre.SelectedItem != null) // ✅ Sécurisation contre les erreurs
            {
                ChargerEvenements(cbFiltre.SelectedItem.ToString());
            }

        }

        private void btnStat_Click(object sender, EventArgs e)
        {
            FormStatistiquesEvenement formStats = new FormStatistiquesEvenement();  
            formStats.Show();  
        }
    }
}
