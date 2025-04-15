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
    public partial class FormStatistiques : Form
    {
        public FormStatistiques()
        {
            InitializeComponent();
            ChargerStatistiques();
        }

        private void AppliquerStyle()
        {
            this.Text = "Statistiques Générales";
            this.BackColor = Color.WhiteSmoke;
            this.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Style pour les labels
            AppliquerStyleLabel(lblNbUtilisateurs, "👥 Total utilisateurs : ");
            AppliquerStyleLabel(lblNbEvenements, "📅 Total événements : ");
            AppliquerStyleLabel(lblTauxParticipation, "📈 Taux de participation : ");

            // Style des boutons
            AppliquerStyleBouton(btnRafraichirStats, "Rafraîchir");
            AppliquerStyleBouton(btnFermer, "Fermer");
        }

        private void AppliquerStyleLabel(Label label, string prefixe)
        {
            label.ForeColor = Color.FromArgb(30, 30, 60);
            label.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            label.AutoSize = true;
        }

        private void AppliquerStyleBouton(Button bouton, string texte)
        {
            bouton.FlatStyle = FlatStyle.Flat;
            bouton.FlatAppearance.BorderSize = 0;
            bouton.BackColor = Color.SteelBlue;
            bouton.ForeColor = Color.White;
            bouton.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            bouton.Height = 40;
            bouton.Width = 160;
            bouton.Text = texte;
        }

        private void ChargerStatistiques()
        {
            // Récupère le nombre total d’utilisateurs
            int totalUtilisateurs = BDD.GetNombreUtilisateurs();

            // Récupère le nombre total d’événements
            int totalEvenements = BDD.GetNombreEvenements();

            // Récupère le taux de participation moyen
            double tauxParticipation = BDD.GetTauxParticipation();

            // Affiche les résultats dans des labels ou dans un message
            lblNbUtilisateurs.Text = $"👥 Total utilisateurs : {totalUtilisateurs}";
            lblNbEvenements.Text = $"📅 Total événements : {totalEvenements}";
            tauxParticipation *= 100;
            lblTauxParticipation.Text = $"📈 Taux de participation : {tauxParticipation:F2}%";

        }

        private void btnRafraichirStats_Click(object sender, EventArgs e)
        {
            ChargerStatistiques();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
