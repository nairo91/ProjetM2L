using AppContactEvenementM2Lv5;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
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

            cbFiltre.SelectedIndex = 0;
            cbFiltre.SelectedIndexChanged += cbFiltre_SelectedIndexChanged;
            ArrondirBouton(btnAjouter);
            ArrondirBouton(btnSupprimer);
            ArrondirBouton(btnAfficher);
            ArrondirBouton(btnRetour);
            ArrondirBouton(btnModifier);
            //ArrondirBouton(button1); // pour inscription
            ArrondirBouton(btnDesinscrire);
            ArrondirBouton(btnMesEvenements);
            ArrondirBouton(btnEvenementsCrees);
            ArrondirBouton(btnStat);
        }

        private void ChargerEvenements(string filtre = "Tous")
        {
            List<Evenement> evenements = evenementDAO.ObtenirEvenements();
            evenements = evenements.OrderBy(e => e.GetDate()).ToList();
            DateTime aujourdHui = DateTime.Today;

            // Appliquer le filtre
            if (filtre == "À venir")
            {
                evenements = evenements.Where(e => e.GetDate() >= aujourdHui.AddDays(1)).ToList();
            }
            else if (filtre == "En cours")
            {
                evenements = evenements.Where(e => e.GetDate().Date == aujourdHui).ToList();
            }
            else if (filtre == "Passés")
            {
                evenements = evenements.Where(e => e.GetDate().Date < aujourdHui).ToList();
            }

            // ✅ Nettoyer le DataGridView avant de remplir
            dgvEvenements.Columns.Clear();
            dgvEvenements.Rows.Clear();

            // ✅ Ajouter les colonnes manquantes
            dgvEvenements.Columns.Add("Id", "ID");
            dgvEvenements.Columns.Add("Nom", "Nom");
            dgvEvenements.Columns.Add("Date", "Date");
            dgvEvenements.Columns.Add("Lieu", "Lieu");
            dgvEvenements.Columns.Add("Description", "Description");
            dgvEvenements.Columns.Add("NbMaxParticipants", "Participants max");
            dgvEvenements.Columns.Add("Participants", "Participants");

            // ✅ Remplir manuellement chaque ligne
            foreach (var evt in evenements)
            {
                dgvEvenements.Rows.Add(evt.GetId(), evt.GetNom(), evt.GetDate().ToString("dd/MM/yyyy"),
                                       evt.GetLieu(), evt.GetDescription(), evt.GetNbMaxParticipants(),
                                       evenementDAO.NombreParticipants(evt.GetId()));
            }

            // ✅ Cacher l'ID si besoin
            dgvEvenements.Columns["Id"].Visible = false;
            dgvEvenements.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void NettoyerChamps()
        {
            txtNom.Clear();
            dtpDate.Value = DateTime.Now;
            txtLieu.Clear();
            txtDescription.Clear();
            numParticipants.Value = 0;
        }

        private void btnAjouter_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNom.Text) || string.IsNullOrWhiteSpace(txtLieu.Text))
            {
                MessageBox.Show("Veuillez remplir les champs obligatoires (Nom et Lieu).", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Evenement evt = new Evenement();
            evt.SetNom(txtNom.Text);
            evt.SetDate(dtpDate.Value);
            evt.SetLieu(txtLieu.Text);
            evt.SetDescription(txtDescription.Text);
            evt.SetNbMaxParticipants((int)numParticipants.Value);

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

        private void btnRetour_Click(object sender, EventArgs e)
        {
            FormSelection formSelection = new FormSelection(utilisateurConnecteId);
            formSelection.Show();
            this.Close();
        }

        private void dgvEvenements_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvEvenements.Rows[e.RowIndex];

                txtNom.Text = selectedRow.Cells["Nom"].Value?.ToString() ?? "";
                txtLieu.Text = selectedRow.Cells["Lieu"].Value?.ToString() ?? "";
                txtDescription.Text = selectedRow.Cells["Description"].Value?.ToString() ?? "";

                // ✅ Vérification de la date pour éviter l'erreur "ArgumentOutOfRangeException"
                if (selectedRow.Cells["Date"].Value != null && DateTime.TryParse(selectedRow.Cells["Date"].Value.ToString(), out DateTime eventDate))
                {
                    if (eventDate >= dtpDate.MinDate && eventDate <= dtpDate.MaxDate)
                        dtpDate.Value = eventDate;
                    else
                        dtpDate.Value = DateTime.Now;
                }
                else
                {
                    dtpDate.Value = DateTime.Now; // Défaut si la date est invalide
                }

                numParticipants.Value = selectedRow.Cells["NbMaxParticipants"].Value != DBNull.Value
                    ? Convert.ToInt32(selectedRow.Cells["NbMaxParticipants"].Value)
                    : 0;
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvEvenements.SelectedRows.Count > 0)
            {
                int evenementId = Convert.ToInt32(dgvEvenements.SelectedRows[0].Cells["Id"].Value);

                if (!evenementDAO.EstCreateurEvenement(evenementId, utilisateurConnecteId))
                {
                    MessageBox.Show("Vous ne pouvez modifier que vos propres événements.");
                    return;
                }

                string nouveauNom = txtNom.Text;
                DateTime nouvelleDate = dtpDate.Value;
                string nouveauLieu = txtLieu.Text;
                string nouvelleDescription = txtDescription.Text;
                int? nouveauNbMaxParticipants = numParticipants.Value > 0 ? (int)numParticipants.Value : (int?)null;

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
            List<Evenement> evenements = evenementDAO.ObtenirMesEvenements(utilisateurConnecteId);

            dgvEvenements.Columns.Clear();
            dgvEvenements.Rows.Clear();

            dgvEvenements.Columns.Add("Id", "ID");
            dgvEvenements.Columns.Add("Nom", "Nom");
            dgvEvenements.Columns.Add("Date", "Date");
            dgvEvenements.Columns.Add("Lieu", "Lieu");
            dgvEvenements.Columns.Add("Description", "Description");
            dgvEvenements.Columns.Add("NbMaxParticipants", "Participants max");
            dgvEvenements.Columns.Add("Participants", "Participants");

            foreach (var evt in evenements)
            {
                dgvEvenements.Rows.Add(evt.GetId(), evt.GetNom(),
                                       evt.GetDate() == DateTime.MinValue ? "Non défini" : evt.GetDate().ToString("dd/MM/yyyy"),
                                       evt.GetLieu(), evt.GetDescription(), evt.GetNbMaxParticipants(),
                                       evenementDAO.NombreParticipants(evt.GetId()));
            }

            dgvEvenements.Columns["Id"].Visible = false;
            dgvEvenements.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnEvenementsCrees_Click(object sender, EventArgs e)
        {
            List<Evenement> evenements = evenementDAO.ObtenirEvenementsCrees(utilisateurConnecteId);

            dgvEvenements.Columns.Clear();
            dgvEvenements.Rows.Clear();

            dgvEvenements.Columns.Add("Id", "ID");
            dgvEvenements.Columns.Add("Nom", "Nom");
            dgvEvenements.Columns.Add("Date", "Date");
            dgvEvenements.Columns.Add("Lieu", "Lieu");
            dgvEvenements.Columns.Add("Description", "Description");
            dgvEvenements.Columns.Add("NbMaxParticipants", "Participants max");
            dgvEvenements.Columns.Add("Participants", "Participants");

            foreach (var evt in evenements)
            {
                dgvEvenements.Rows.Add(evt.GetId(), evt.GetNom(),
                                       evt.GetDate() == DateTime.MinValue ? "Non défini" : evt.GetDate().ToString("dd/MM/yyyy"),
                                       evt.GetLieu(), evt.GetDescription(), evt.GetNbMaxParticipants(),
                                       evenementDAO.NombreParticipants(evt.GetId()));
            }

            dgvEvenements.Columns["Id"].Visible = false;
            dgvEvenements.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void cbFiltre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFiltre.SelectedItem != null)
            {
                ChargerEvenements(cbFiltre.SelectedItem.ToString());
            }
        }

        private void btnStat_Click(object sender, EventArgs e)
        {
            FormStatistiquesEvenement formStats = new FormStatistiquesEvenement();
            formStats.Show();
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            // Optionnel : traitement à faire lors d'une modification
        }

        private void txtLieu_TextChanged(object sender, EventArgs e)
        {
            // Optionnel
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Optionnel
        }

        private void numParticipants_ValueChanged(object sender, EventArgs e)
        {
            // Optionnel
        }

        private void dgvEvenements_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optionnel
        }

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private void ArrondirBouton(Button bouton)
        {
            bouton.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, bouton.Width, bouton.Height, 20, 20));
        }


    }
}


