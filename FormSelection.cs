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
    public partial class FormSelection : Form
    {
        private int utilisateurConnecteId;
        public FormSelection(int utilisateurId)
        {
            InitializeComponent();
            utilisateurConnecteId = utilisateurId;
        }

        private void btnContacts_Click(object sender, EventArgs e)
        {
           
            
                Form2 formContacts = new Form2(utilisateurConnecteId); // Passe l'ID utilisateur
                formContacts.Show();
                this.Hide(); // Cache la page de sélection
            

        }

        private void btnEvenements_Click(object sender, EventArgs e)
        {
            FormEvenement formEvenements = new FormEvenement(utilisateurConnecteId);
            formEvenements.Show();
            this.Hide();  // Cache la page de sélection
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            Form1 formLogin = new Form1();
            formLogin.Show();
            this.Close(); // Ferme la fenêtre actuelle
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            FormProfil formProfil = new FormProfil(utilisateurConnecteId);
            formProfil.ShowDialog();
        }
    }
}
