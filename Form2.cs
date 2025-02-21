using MySql.Data.MySqlClient;  // Importation du namespace pour MySQL
using Mysqlx.Resultset;
using System;
using System.Data;
using System.Windows.Forms;

namespace AppLegeayControles
{
    public partial class Form2 : Form
    {
        private int utilisateurConnecteId; // ID de l'utilisateur connecté

        // Constructeur du formulaire Form2
        public Form2(int utilisateurId)
        {
            InitializeComponent();  // Initialisation des composants du formulaire
            utilisateurConnecteId = utilisateurId;


            // TextBox style
            txtNom.BorderStyle = BorderStyle.FixedSingle;
            txtNom.Font = new Font("Segoe UI", 10);
            txtNom.BackColor = Color.WhiteSmoke;

            // Button style
            btnAddContact.FlatStyle = FlatStyle.Flat;
            btnAddContact.BackColor = Color.LightSteelBlue;
            btnAddContact.ForeColor = Color.White;
            btnAddContact.Font = new Font("Segoe UI", 10, FontStyle.Bold);


            btnDelContact.FlatStyle = FlatStyle.Flat;
            btnDelContact.BackColor = Color.LightSteelBlue;
            btnDelContact.ForeColor = Color.White;
            btnDelContact.Font = new Font("Segoe UI", 10, FontStyle.Bold);


            btnModifierContact.FlatStyle = FlatStyle.Flat;
            btnModifierContact.BackColor = Color.LightSteelBlue;
            btnModifierContact.ForeColor = Color.White;
            btnModifierContact.Font = new Font("Segoe UI", 10, FontStyle.Bold);



            // DataGridView style
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.GridColor = Color.LightGray;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSteelBlue;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView1.EnableHeadersVisualStyles = false;

        }

        private int GetUtilisateurId()
        {
            // Récupère l'ID de l'utilisateur connecté à partir de la table utilisateurs
            string query = "SELECT id FROM utilisateurs WHERE email = @email";

            // Connexion à la base de données
            MySqlConnection conn = BDD.GetConnection();

            try
            {
                // Ouvre la connexion si elle est fermée
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);

                // Exécuter la requête
                int utilisateurId = Convert.ToInt32(cmd.ExecuteScalar());

                return utilisateurId;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}");
                return -1;  // Renvoie une valeur par défaut en cas d'erreur
            }
            finally
            {
                // Fermer la connexion après usage
                BDD.CloseConnection();
            }
        }


       

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }


        private void Form2_Load(object sender, EventArgs e)
        {
            // Abonnement à l'événement SelectionChanged du DataGridView
            dataGridView1.SelectionChanged += new EventHandler(DataGridView1_SelectionChanged);
            btnAfficherContact_Click_1(sender, e);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Vérifie si une ligne est sélectionnée
            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells["nom"].Value != null)
            {
                // Récupère la ligne sélectionnée
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Assigne les valeurs de la ligne sélectionnée aux TextBox correspondantes
                txtNom.Text = selectedRow.Cells["nom"].Value?.ToString() ?? "";
                txtTelephone.Text = selectedRow.Cells["telephone"].Value?.ToString() ?? "";
                txtEmail.Text = selectedRow.Cells["email"].Value?.ToString() ?? "";
                txtAdresse.Text = selectedRow.Cells["adresse"].Value?.ToString() ?? "";
            }
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            FormSelection formSelection = new FormSelection(utilisateurConnecteId);
            formSelection.Show();
            this.Close(); // Ferme la fenêtre actuelle
        }

        private void btnAddContact_Click_1(object sender, EventArgs e)
        {
            string nom = txtNom.Text;
            string telephone = txtTelephone.Text;
            string email = txtEmail.Text;
            string adresse = txtAdresse.Text;

            // Récupère l'ID de l'utilisateur connecté
            int utilisateurId = GetUtilisateurId();
            if (utilisateurId == -1)
            {
                MessageBox.Show("Erreur lors de la récupération de l'ID utilisateur.");
                return;
            }

            // Validation du téléphone
            if (telephone.Length != 10 || !telephone.All(char.IsDigit))
            {
                MessageBox.Show("Veuillez entrer un numéro de téléphone valide (10 chiffres).");
                return; // Arrêter l'exécution si la validation échoue
            }

            string query = "INSERT INTO contacts (utilisateur_id, nom, telephone, email, adresse) VALUES (@utilisateurId, @nom, @telephone, @email, @adresse)";

            try
            {
                MySqlConnection conn = BDD.GetConnection();
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@utilisateurId", utilisateurConnecteId);
                cmd.Parameters.AddWithValue("@nom", nom);
                cmd.Parameters.AddWithValue("@telephone", telephone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@adresse", adresse);

                int result = cmd.ExecuteNonQuery();



                if (result > 0)
                {
                   // MessageBox.Show("Contact ajouté avec succès !");

                    string checkQuery = "SELECT COUNT(*) FROM contacts WHERE utilisateur_id = @utilisateurId";
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@utilisateurId", utilisateurConnecteId);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                   // MessageBox.Show($"Nombre total de contacts pour l'utilisateur après ajout : {count}");


                    // Appeler la méthode pour rafraîchir les contacts dans le DataGridView
                    btnAfficherContact_Click_1(sender, e);
                }
                else
                {
                    MessageBox.Show("Erreur lors de l'ajout du contact.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}");
            }
            finally
            {
                BDD.CloseConnection();
            }
        }

        private void btnModifierContact_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Récupération des informations saisies pour le contact
                string nom = txtNom.Text;
                string telephone = txtTelephone.Text;
                string email = txtEmail.Text;
                string adresse = txtAdresse.Text;

                // Récupération de l'ID du contact à modifier, par exemple à partir d'une ligne sélectionnée dans le DataGridView
                int contactId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                //int contactkk = dataGridView1.selected

                // Requête SQL pour mettre à jour le contact sélectionné
                string query = "UPDATE contacts SET nom = @nom, telephone = @telephone, email = @email, adresse = @adresse WHERE id = @contactId";




                try
                {
                    // Connexion à la base de données
                    MySqlConnection conn = BDD.GetConnection();

                    // Ouvre la connexion si elle est fermée
                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    // Préparation de la commande SQL
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nom", nom);
                    cmd.Parameters.AddWithValue("@telephone", telephone);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@adresse", adresse);
                    cmd.Parameters.AddWithValue("@contactId", contactId);

                    // Exécute la requête de mise à jour
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Contact modifié avec succès !");
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de la modification du contact.");
                    }

                    // Ferme la connexion à la base de données
                    BDD.CloseConnection();
                }
                catch (Exception ex)
                {
                    // Gestion des erreurs et affichage du message d'erreur
                    MessageBox.Show($"Erreur : {ex.Message}");
                }
            }
        }

        private void btnDelContact_Click_1(object sender, EventArgs e)
        {
            // Récupération de l'ID du contact à supprimer, à partir de la ligne sélectionnée dans le DataGridView
            int contactId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);

            // Requête SQL pour supprimer le contact sélectionné
            string query = "DELETE FROM contacts WHERE id = @contactId";

            try
            {
                // Connexion à la base de données
                MySqlConnection conn = BDD.GetConnection();

                // Ouvre la connexion si elle est fermée
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }

                // Préparation de la commande SQL
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@contactId", contactId);

                // Exécute la requête de suppression
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Contact supprimé avec succès !");
                }
                else
                {
                    MessageBox.Show("Erreur lors de la suppression du contact.");
                }

                // Ferme la connexion à la base de données
                BDD.CloseConnection();
            }
            catch (Exception ex)
            {
                // Gestion des erreurs et affichage du message d'erreur
                MessageBox.Show($"Erreur : {ex.Message}");
            }
        }

        private void btnAfficherContact_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un contact à modifier.");
                return;
            }

            // Vérification si la colonne "id" existe et a une valeur valide
            if (dataGridView1.SelectedRows[0].Cells["id"].Value == null ||
                string.IsNullOrWhiteSpace(dataGridView1.SelectedRows[0].Cells["id"].Value.ToString()))
            {
                MessageBox.Show("Erreur : l'ID du contact est introuvable !");
                return;
            }

            int contactId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
            string nom = txtNom.Text;
            string telephone = txtTelephone.Text;
            string email = txtEmail.Text;
            string adresse = txtAdresse.Text;

            string query = "UPDATE contacts SET nom = @nom, telephone = @telephone, email = @email, adresse = @adresse WHERE id = @contactId";

            try
            {
                MySqlConnection conn = BDD.GetConnection();
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nom", nom);
                cmd.Parameters.AddWithValue("@telephone", telephone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@adresse", adresse);
                cmd.Parameters.AddWithValue("@contactId", contactId);

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Contact modifié avec succès !");
                }
                else
                {
                    MessageBox.Show("Erreur lors de la modification du contact.");
                }

                BDD.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells["nom"].Value != null)
            {
                // Récupérer la ligne sélectionnée
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Remplir les champs avec les valeurs correspondantes
                txtNom.Text = selectedRow.Cells["nom"].Value?.ToString() ?? "";
                txtTelephone.Text = selectedRow.Cells["telephone"].Value?.ToString() ?? "";
                txtEmail.Text = selectedRow.Cells["email"].Value?.ToString() ?? "";
                txtAdresse.Text = selectedRow.Cells["adresse"].Value?.ToString() ?? "";

                MessageBox.Show($"Contact sélectionné : {txtNom.Text}, {txtTelephone.Text}, {txtEmail.Text}, {txtAdresse.Text}");
            }
        }
    }
}