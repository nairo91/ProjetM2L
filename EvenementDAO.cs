using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace AppLegeayControles
{
    internal class EvenementDAO
    {
        // Ajouter un événement
        public void AjouterEvenement(Evenement evt, int createurId)
        {
            string query = "INSERT INTO evenements (nom, date, lieu, description, nb_max_participants, createur_id) " +
                    "VALUES (@nom, @date, @lieu, @description, @nbMaxParticipants, @createurId)";

            try
            {
                BDD.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, BDD.GetConnection());
                cmd.Parameters.AddWithValue("@nom", evt.Nom);
                cmd.Parameters.AddWithValue("@date", evt.Date);
                cmd.Parameters.AddWithValue("@lieu", evt.Lieu);
                cmd.Parameters.AddWithValue("@description", evt.Description);
                cmd.Parameters.AddWithValue("@nbMaxParticipants", evt.NbMaxParticipants ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@createurId", createurId);

                cmd.ExecuteNonQuery();

                // Récupérer l'ID de l'événement ajouté
                int evenementId = (int)cmd.LastInsertedId;

                // Inscription automatique du créateur à son propre événement
                string inscriptionQuery = "INSERT INTO inscriptions (utilisateur_id, evenement_id) VALUES (@utilisateurId, @evenementId)";
                MySqlCommand inscriptionCmd = new MySqlCommand(inscriptionQuery, BDD.GetConnection());
                inscriptionCmd.Parameters.AddWithValue("@utilisateurId", createurId);
                inscriptionCmd.Parameters.AddWithValue("@evenementId", evenementId);
                inscriptionCmd.ExecuteNonQuery();

                BDD.CloseConnection();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors de l'ajout d'un événement : {ex.Message}");
            }
        }

        // Récupérer la liste des événements
        public List<Evenement> ObtenirEvenements()
        {
            List<Evenement> evenements = new List<Evenement>();
            //string query = "SELECT * FROM evenements";
            string query = "SELECT id, nom, date, lieu, description, nb_max_participants FROM evenements";

            try
            {
                BDD.OpenConnection();
                MySqlDataReader reader = BDD.ExecuteSelect(query);

                while (reader.Read())
                {
                    evenements.Add(new Evenement
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        Nom = reader["nom"].ToString(),
                        Date = Convert.ToDateTime(reader["date"]),
                        Lieu = reader["lieu"].ToString(),
                        Description = reader["description"].ToString(),
                        NbMaxParticipants = reader["nb_max_participants"] != DBNull.Value ? Convert.ToInt32(reader["nb_max_participants"]) : (int?)null
                    });
                }
                reader.Close();
                BDD.CloseConnection();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors de la récupération des événements : {ex.Message}");
            }

            return evenements;
        }

        
        public bool SupprimerEvenement(int id, int utilisateurId)
        {
            string checkQuery = "SELECT createur_id FROM evenements WHERE id = @id";
            try
            {
                BDD.OpenConnection();
                MySqlCommand checkCmd = new MySqlCommand(checkQuery, BDD.GetConnection());
                checkCmd.Parameters.AddWithValue("@id", id);
                object result = checkCmd.ExecuteScalar();

                if (result == null)
                {
                    MessageBox.Show("Événement introuvable !");
                    return false;
                }

                int createurId = Convert.ToInt32(result);

                MessageBox.Show($"Utilisateur connecté : {utilisateurId}, Créateur de l'événement : {createurId}");

                if (createurId != utilisateurId)
                {
                    MessageBox.Show("Vous ne pouvez supprimer que vos propres événements.");
                    return false;
                }

                string deleteQuery = "DELETE FROM evenements WHERE id = @id AND createur_id = @utilisateurId";
                MySqlCommand cmd = new MySqlCommand(deleteQuery, BDD.GetConnection());
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@utilisateurId", utilisateurId);
                cmd.ExecuteNonQuery();
                BDD.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la suppression : {ex.Message}");
                return false;
            }
        }

       
        public bool ModifierEvenement(int evenementId, int utilisateurId, string nom, DateTime date, string lieu, string description, int? nbMaxParticipants)
        {
            string query = "UPDATE evenements SET nom = @nom, date = @date, lieu = @lieu, description = @description, nb_max_participants = @nbMaxParticipants WHERE id = @id AND createur_id = @utilisateurId";

            try
            {
                BDD.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, BDD.GetConnection());
                cmd.Parameters.AddWithValue("@id", evenementId);
                cmd.Parameters.AddWithValue("@utilisateurId", utilisateurId);
                cmd.Parameters.AddWithValue("@nom", nom);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@lieu", lieu);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@nbMaxParticipants", nbMaxParticipants ?? (object)DBNull.Value);

                int result = cmd.ExecuteNonQuery();
                BDD.CloseConnection();

                return result > 0; // Retourne true si la modification a réussi
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors de la modification de l'événement : {ex.Message}");
                return false;
            }
        }



        
        public bool EstCreateurEvenement(int evenementId, int utilisateurId)
        {
            string query = "SELECT COUNT(*) FROM evenements WHERE id = @id AND createur_id = @utilisateurId";

            try
            {
                BDD.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, BDD.GetConnection());
                cmd.Parameters.AddWithValue("@id", evenementId);
                cmd.Parameters.AddWithValue("@utilisateurId", utilisateurId);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                BDD.CloseConnection();

                return count > 0; 
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors de la vérification du créateur : {ex.Message}");
                return false;
            }
        }


        public bool InscrireUtilisateur(int utilisateurId, int evenementId)
        {
            string query = "INSERT INTO inscriptions (utilisateur_id, evenement_id) VALUES (@utilisateurId, @evenementId)";

            try
            {
                BDD.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, BDD.GetConnection());
                cmd.Parameters.AddWithValue("@utilisateurId", utilisateurId);
                cmd.Parameters.AddWithValue("@evenementId", evenementId);
                int result = cmd.ExecuteNonQuery();
                BDD.CloseConnection();
                return result > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors de l'inscription : {ex.Message}");
                return false;
            }
        }

       
        public bool DesinscrireUtilisateur(int utilisateurId, int evenementId)
        {
            string query = "DELETE FROM inscriptions WHERE utilisateur_id = @utilisateurId AND evenement_id = @evenementId";

            try
            {
                BDD.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, BDD.GetConnection());
                cmd.Parameters.AddWithValue("@utilisateurId", utilisateurId);
                cmd.Parameters.AddWithValue("@evenementId", evenementId);
                int result = cmd.ExecuteNonQuery();
                BDD.CloseConnection();
                return result > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors de la désinscription : {ex.Message}");
                return false;
            }
        }

        
        public bool EstInscrit(int utilisateurId, int evenementId)
        {
            string query = "SELECT COUNT(*) FROM inscriptions WHERE utilisateur_id = @utilisateurId AND evenement_id = @evenementId";

            try
            {
                BDD.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, BDD.GetConnection());
                cmd.Parameters.AddWithValue("@utilisateurId", utilisateurId);
                cmd.Parameters.AddWithValue("@evenementId", evenementId);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                BDD.CloseConnection();
                return count > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors de la vérification de l'inscription : {ex.Message}");
                return false;
            }
        }


        public int NombreParticipants(int evenementId)
        {
            string query = "SELECT COUNT(*) FROM inscriptions WHERE evenement_id = @evenementId";

            try
            {
                BDD.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, BDD.GetConnection());
                cmd.Parameters.AddWithValue("@evenementId", evenementId);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                BDD.CloseConnection();
                return count;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors de la récupération du nombre de participants : {ex.Message}");
                return 0;
            }
        }

        public List<Evenement> ObtenirMesEvenements(int utilisateurId)
        {
            List<Evenement> evenements = new List<Evenement>();
            string query = @"
        SELECT e.* FROM evenements e
        INNER JOIN inscriptions i ON e.id = i.evenement_id
        WHERE i.utilisateur_id = @id";

            try
            {
                BDD.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, BDD.GetConnection());
                cmd.Parameters.AddWithValue("@id", utilisateurId);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    evenements.Add(new Evenement
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        Nom = reader["nom"].ToString(),
                        Date = Convert.ToDateTime(reader["date"]),
                        Lieu = reader["lieu"].ToString(),
                        Description = reader["description"].ToString(),
                        NbMaxParticipants = reader["nb_max_participants"] != DBNull.Value ? Convert.ToInt32(reader["nb_max_participants"]) : (int?)null
                    });
                }
                reader.Close();
                BDD.CloseConnection();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors de la récupération des événements inscrits : {ex.Message}");
            }

            return evenements;
        }

        public List<Evenement> ObtenirEvenementsCrees(int utilisateurId)
        {
            List<Evenement> evenements = new List<Evenement>();
            string query = "SELECT * FROM evenements WHERE createur_id = @id";

            try
            {
                BDD.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, BDD.GetConnection());
                cmd.Parameters.AddWithValue("@id", utilisateurId);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    evenements.Add(new Evenement
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        Nom = reader["nom"].ToString(),
                        Date = Convert.ToDateTime(reader["date"]),
                        Lieu = reader["lieu"].ToString(),
                        Description = reader["description"].ToString(),
                        NbMaxParticipants = reader["nb_max_participants"] != DBNull.Value ? Convert.ToInt32(reader["nb_max_participants"]) : (int?)null
                    });
                }
                reader.Close();
                BDD.CloseConnection();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors de la récupération des événements créés : {ex.Message}");
            }

            return evenements;
        }

    }
}
