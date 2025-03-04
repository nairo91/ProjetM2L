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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


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

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            // Chemin du fichier PDF à générer
            string filePath = @"C:\Users\orian\Downloads\StatistiquesEvenements.pdf";


            // Créer un document au format A4 avec des marges personnalisées
            Document document = new Document(PageSize.A4, 25, 25, 30, 30);

            try
            {
                PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
                document.Open();

                // Définir la couleur navy comme BaseColor(0, 0, 128)
                BaseColor navyColor = new BaseColor(0, 0, 128);

                // Ajouter un titre centré
                Paragraph title = new Paragraph("Statistiques des Événements",
                    FontFactory.GetFont("Helvetica", 16, iTextSharp.text.Font.BOLD, navyColor));
                title.Alignment = Element.ALIGN_CENTER;
                document.Add(title);
                document.Add(new Paragraph(" ")); // Ligne vide pour l'espacement

                // Créer un tableau PDF avec le même nombre de colonnes que le DataGridView
                PdfPTable pdfTable = new PdfPTable(dgvStats.Columns.Count);
                pdfTable.WidthPercentage = 100;

                // Ajouter les en-têtes de colonnes avec style personnalisé
                foreach (DataGridViewColumn column in dgvStats.Columns)
                {
                    PdfPCell headerCell = new PdfPCell(new Phrase(column.HeaderText,
                        FontFactory.GetFont("Helvetica", 10, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                    headerCell.BackgroundColor = navyColor;
                    headerCell.HorizontalAlignment = Element.ALIGN_CENTER;
                    pdfTable.AddCell(headerCell);
                }

                // Ajouter les données du DataGridView au tableau
                foreach (DataGridViewRow row in dgvStats.Rows)
                {
                    if (row.IsNewRow)
                        continue; // Ignorer la ligne vide
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        pdfTable.AddCell(new Phrase(cell.Value?.ToString() ?? "",
                            FontFactory.GetFont("Helvetica", 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)));
                    }
                }

                // Ajouter le tableau au document
                document.Add(pdfTable);
                MessageBox.Show("Export PDF créé avec succès !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'export PDF : " + ex.Message);
            }
            finally
            {
                document.Close();
            }
        }
    }
}
