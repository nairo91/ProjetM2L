using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppContactEvenementM2Lv5;
using AppLegeayControles;


namespace AppContactEvenementM2Lv5
{
    public partial class FormStatistiquesEvenement : Form
    {
        public FormStatistiquesEvenement()
        {
            InitializeComponent();
            ChargerStatistiques();
        }

        private void dgvStats_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ChargerStatistiques()
        {
            EvenementDAO evenementDAO = new EvenementDAO();  // ✅ Instanciation correcte de la classe
            DataTable statistiques = evenementDAO.ObtenirStatistiquesEvenements();  // ✅ Récupération des stats
            dgvStats.DataSource = statistiques;  // ✅ Affichage dans le DataGridView

        }

    }
}
