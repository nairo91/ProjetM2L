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
            AppliquerStyleProfessionnel();

        }


        private void AppliquerStyleProfessionnel()
        {
            this.BackColor = Color.WhiteSmoke;
            this.Text = "Choix de gestion";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Style général des boutons
            StyleBouton(btnEvenements, "Événement", Color.Navy, Color.White, new Size(300, 100));
            StyleBouton(btnProfil, "Mettre à jour mes infos", Color.DarkBlue, Color.White, new Size(260, 60)); // largeur réduite
            StyleBouton(btnDeconnexion, "Déconnexion", Color.DarkRed, Color.White, new Size(200, 60));

            // Centrage horizontal propre des deux petits boutons
            int centreX = (this.ClientSize.Width - (btnProfil.Width + 20 + btnDeconnexion.Width)) / 2;

            btnEvenements.Location = new Point((this.ClientSize.Width - btnEvenements.Width) / 2, 100);
            btnProfil.Location = new Point(centreX, 230);
            btnDeconnexion.Location = new Point(centreX + btnProfil.Width + 20, 230);
        }

        private void StyleBouton(Button bouton, string texte, Color bgColor, Color fgColor, Size taille)
        {
            bouton.Text = texte;
            bouton.BackColor = bgColor;
            bouton.ForeColor = fgColor;
            bouton.FlatStyle = FlatStyle.Flat;
            bouton.FlatAppearance.BorderSize = 0;
            bouton.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            bouton.Size = taille;
            bouton.Cursor = Cursors.Hand;
            bouton.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, bouton.Width, bouton.Height, 20, 20));
        }

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect,
            int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);


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
