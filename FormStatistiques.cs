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

        private void ChargerStatistiques()
        {
            // Récupère le nombre total d’utilisateurs
            int totalUtilisateurs = BDD.GetNombreUtilisateurs();

            // Récupère le nombre total d’événements
            int totalEvenements = BDD.GetNombreEvenements();

            // Récupère le taux de participation moyen
            double tauxParticipation = BDD.GetTauxParticipation();

            // Affiche les résultats dans des labels ou dans un message

            lblNbUtilisateurs.Text = $"Total utilisateurs : {totalUtilisateurs}";
            lblNbEvenements.Text = $"Total événements : {totalEvenements}";
            tauxParticipation *= 100;
            lblTauxParticipation.Text = $"Taux de participation : {tauxParticipation}%";
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
