using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace AppLegeayControles
{
    internal class EvenementDAO
    {
        public void AjouterEvenement(Evenement evt, int createurId)
        {
            string query = "INSERT INTO evenements (nom, date, lieu, description, nb_max_participants, createur_id) " +
                           "VALUES (@nom, @date, @lieu, @description, @nbMaxParticipants, @createurId)";

            try
            {
                BDD.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, BDD.GetConnection());
                cmd.Parameters.AddWithValue("@nom", evt.GetNom());
                cmd.Parameters.AddWithValue("@date", evt.GetDate());
                cmd.Parameters.AddWithValue("@lieu", evt.GetLieu());
                cmd.Parameters.AddWithValue("@description", evt.GetDescription());
                cmd.Parameters.AddWithValue("@nbMaxParticipants", evt.GetNbMaxParticipants() ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@createurId", createurId);
                cmd.ExecuteNonQuery();

                int evenementId = (int)cmd.LastInsertedId;
                InscrireCreateur(evenementId, createurId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors de l'ajout d'un événement : {ex.Message}");
            }
            finally
            {
                BDD.CloseConnection();
            }
        }

        public List<Evenement> ObtenirEvenements()
        {
            List<Evenement> evenements = new List<Evenement>();
            string query = "SELECT id, nom, date, lieu, description, nb_max_participants FROM evenements";

            try
            {
                BDD.OpenConnection();
                MySqlDataReader reader = BDD.ExecuteSelect(query);

                while (reader.Read())
                {
                    Evenement evt = new Evenement();
                    evt.SetId(Convert.ToInt32(reader["id"]));
                    evt.SetNom(reader["nom"].ToString());
                    evt.SetDate(Convert.ToDateTime(reader["date"]));
                    evt.SetLieu(reader["lieu"].ToString());
                    evt.SetDescription(reader["description"].ToString());
                    evt.SetNbMaxParticipants(reader["nb_max_participants"] != DBNull.Value ? Convert.ToInt32(reader["nb_max_participants"]) : (int?)null);
                    evenements.Add(evt);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors de la récupération des événements : {ex.Message}");
            }
            finally
            {
                BDD.CloseConnection();
            }

            return evenements;
        }

        public bool SupprimerEvenement(int id, int utilisateurId)
        {
            if (!EstCreateurEvenement(id, utilisateurId))
            {
                MessageBox.Show("Vous ne pouvez supprimer que vos propres événements.");
                return false;
            }

            string deleteQuery = "DELETE FROM evenements WHERE id = @id AND createur_id = @utilisateurId";
            try
            {
                BDD.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(deleteQuery, BDD.GetConnection());
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@utilisateurId", utilisateurId);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la suppression : {ex.Message}");
                return false;
            }
            finally
            {
                BDD.CloseConnection();
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
                return result > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors de la modification de l'événement : {ex.Message}");
                return false;
            }
            finally
            {
                BDD.CloseConnection();
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
                return count > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors de la vérification du créateur : {ex.Message}");
                return false;
            }
            finally
            {
                BDD.CloseConnection();
            }
        }

        public bool InscrireUtilisateur(int utilisateurId, int evenementId)
        {
            // ✅ Vérifier le nombre max de participants
            string maxParticipantsQuery = "SELECT nb_max_participants FROM evenements WHERE id = @evenementId";
            int? nbMaxParticipants = null;

            try
            {
                BDD.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(maxParticipantsQuery, BDD.GetConnection());
                cmd.Parameters.AddWithValue("@evenementId", evenementId);
                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                    nbMaxParticipants = Convert.ToInt32(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la récupération du nombre max de participants : " + ex.Message);
            }
            finally
            {
                BDD.CloseConnection();
            }

            // ✅ Vérifier si l'inscription est possible
            int currentParticipants = NombreParticipants(evenementId);
            if (nbMaxParticipants.HasValue && nbMaxParticipants > 0 && currentParticipants >= nbMaxParticipants)
            {
                MessageBox.Show("L'événement est complet. Impossible de s'inscrire.", "Inscription impossible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // ✅ Inscription de l'utilisateur si la limite n'est pas atteinte
            string query = "INSERT INTO inscriptions (utilisateur_id, evenement_id) VALUES (@utilisateurId, @evenementId)";
            try
            {
                BDD.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, BDD.GetConnection());
                cmd.Parameters.AddWithValue("@utilisateurId", utilisateurId);
                cmd.Parameters.AddWithValue("@evenementId", evenementId);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors de l'inscription : {ex.Message}");
                return false;
            }
            finally
            {
                BDD.CloseConnection();
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
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors de la désinscription : {ex.Message}");
                return false;
            }
            finally
            {
                BDD.CloseConnection();
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
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors de la vérification de l'inscription : {ex.Message}");
                return false;
            }
            finally
            {
                BDD.CloseConnection();
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
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors du comptage des participants : {ex.Message}");
                return 0;
            }
            finally
            {
                BDD.CloseConnection();
            }
        }

        public List<Evenement> ObtenirMesEvenements(int utilisateurId) => ObtenirEvenementsParQuery(@"
            SELECT e.* FROM evenements e
            INNER JOIN inscriptions i ON e.id = i.evenement_id
            WHERE i.utilisateur_id = @id", utilisateurId);

        public List<Evenement> ObtenirEvenementsCrees(int utilisateurId) =>
            ObtenirEvenementsParQuery("SELECT * FROM evenements WHERE createur_id = @id", utilisateurId);

        public DataTable ObtenirStatistiquesEvenements()
        {
            DataTable dt = new DataTable();
            string query = @"
                SELECT e.nom AS 'Nom de l''événement', COUNT(i.utilisateur_id) AS 'Nombre de participants',
                       e.nb_max_participants AS 'Places disponibles',
                       CASE WHEN e.nb_max_participants IS NULL OR e.nb_max_participants = 0 THEN 'N/A'
                       ELSE CONCAT(ROUND((COUNT(i.utilisateur_id) / e.nb_max_participants) * 100, 2), '%') END AS 'Taux de participation'
                FROM evenements e
                LEFT JOIN inscriptions i ON e.id = i.evenement_id
                GROUP BY e.nom, e.nb_max_participants
                ORDER BY COUNT(i.utilisateur_id) DESC";

            try
            {
                BDD.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, BDD.GetConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la récupération des statistiques : " + ex.Message);
            }
            finally
            {
                BDD.CloseConnection();
            }

            return dt;
        }

        private void InscrireCreateur(int evenementId, int utilisateurId)
        {
            string query = "INSERT INTO inscriptions (utilisateur_id, evenement_id) VALUES (@utilisateurId, @evenementId)";
            MySqlCommand cmd = new MySqlCommand(query, BDD.GetConnection());
            cmd.Parameters.AddWithValue("@utilisateurId", utilisateurId);
            cmd.Parameters.AddWithValue("@evenementId", evenementId);
            cmd.ExecuteNonQuery();
        }

        private bool EstLimiteAtteinte(int evenementId)
        {
            int currentCount = NombreParticipants(evenementId);
            int? nbMaxParticipants = null;

            try
            {
                string query = "SELECT nb_max_participants FROM evenements WHERE id = @evenementId";
                MySqlCommand cmd = new MySqlCommand(query, BDD.GetConnection());
                cmd.Parameters.AddWithValue("@evenementId", evenementId);
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                    nbMaxParticipants = Convert.ToInt32(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la vérification du nombre max : " + ex.Message);
            }

            return nbMaxParticipants.HasValue && nbMaxParticipants.Value > 0 && currentCount >= nbMaxParticipants.Value;
        }

        private List<Evenement> ObtenirEvenementsParQuery(string query, int utilisateurId)
        {
            List<Evenement> evenements = new List<Evenement>();
            try
            {
                BDD.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, BDD.GetConnection());
                cmd.Parameters.AddWithValue("@id", utilisateurId);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Evenement evt = new Evenement();
                    evt.SetId(Convert.ToInt32(reader["id"]));
                    evt.SetNom(reader["nom"].ToString());
                    evt.SetDate(Convert.ToDateTime(reader["date"]));
                    evt.SetLieu(reader["lieu"].ToString());
                    evt.SetDescription(reader["description"].ToString());
                    evt.SetNbMaxParticipants(reader["nb_max_participants"] != DBNull.Value ? Convert.ToInt32(reader["nb_max_participants"]) : (int?)null);
                    evenements.Add(evt);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur SQL : " + ex.Message);
            }
            finally
            {
                BDD.CloseConnection();
            }
            return evenements;
        }
    }
}


