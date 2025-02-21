using System;
using MySql.Data.MySqlClient;
using System.Data;

namespace AppLegeayControles
{
    public static class BDD
    {
        private static string connectionString = "server=localhost;port=3306;database=bdcontact;uid=root;pwd=;";
        private static MySqlConnection connection = null;

        // Récupère ou crée une nouvelle connexion
        public static MySqlConnection GetConnection()
        {
            if (connection == null)
            {
                connection = new MySqlConnection(connectionString);
            }
            return connection;
        }

        // Ouvre la connexion si elle est fermée
        public static void OpenConnection()
        {
            if (connection == null)
                connection = GetConnection();
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        // Ferme la connexion si elle est ouverte
        public static void CloseConnection()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        // Exécute une requête qui ne renvoie pas de données (INSERT, UPDATE, DELETE)
        public static int ExecuteQuery(string query)
        {
            OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            int result = cmd.ExecuteNonQuery();
            CloseConnection();
            return result;
        }

        // Exécute une requête qui renvoie des données (SELECT)
        public static MySqlDataReader ExecuteSelect(string query)
        {
            OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            return cmd.ExecuteReader();
        }

        // Méthode pour inscrire un nouvel utilisateur avec des paramètres sécurisés
        public static bool InscrireUtilisateur(string nom, string prenom, string email, string motDePasse)
        {
            string query = "INSERT INTO utilisateurs (nom, prenom, email, mdp) VALUES (@nom, @prenom, @mail, @mdp)";

            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, GetConnection());
                cmd.Parameters.AddWithValue("@nom", nom);
                cmd.Parameters.AddWithValue("@prenom", prenom);
                cmd.Parameters.AddWithValue("@mail", email);
                cmd.Parameters.AddWithValue("@mdp", motDePasse);
                int result = cmd.ExecuteNonQuery();
                CloseConnection();
                return result > 0;  // Retourne vrai si l'insertion réussit
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors de l'inscription : {ex.Message}");
                return false;
            }
        }
    

        // Méthode pour vérifier si un utilisateur existe avec l'email et le mot de passe fournis
        public static bool ConnexionUtilisateur(string email, string motDePasse)
        {
            string query = "SELECT * FROM utilisateurs WHERE email = @mail AND mdp = @mdp";

            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@mail", email);
                cmd.Parameters.AddWithValue("@mdp", motDePasse);
                MySqlDataReader reader = cmd.ExecuteReader();
                bool hasRows = reader.HasRows;  // Vérifie si la requête a retourné des résultats
                reader.Close();
                CloseConnection();
                return hasRows;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors de la connexion : {ex.Message}");
                return false;
            }
        }

        public static int GetUtilisateurId(string email)
        {
            string query = "SELECT id FROM utilisateurs WHERE email = @mail";
            int utilisateurId = -1; // Valeur par défaut en cas d'erreur ou utilisateur introuvable

            try
            {
                OpenConnection(); // Ouvre la connexion à la base de données
                MySqlCommand cmd = new MySqlCommand(query, GetConnection());
                cmd.Parameters.AddWithValue("@mail", email);

                object result = cmd.ExecuteScalar(); // Exécute la requête et récupère un résultat unique
                if (result != null)
                {
                    utilisateurId = Convert.ToInt32(result); // Convertit le résultat en entier
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors de la récupération de l'ID utilisateur : {ex.Message}");
            }
            finally
            {
                CloseConnection(); // Ferme la connexion
            }

            return utilisateurId; // Retourne l'ID utilisateur ou -1 en cas d'erreur
        }

        public static string GetUserRole(string email)
        {
            string role = "user"; // Valeur par défaut

            try
            {
                OpenConnection();
                string query = "SELECT role FROM utilisateurs WHERE email = @Email";
                MySqlCommand cmd = new MySqlCommand(query, GetConnection());
                cmd.Parameters.AddWithValue("@Email", email);

                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    role = result.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la récupération du rôle : " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return role;
        }


        public static DataTable GetAllUtilisateurs()
        {
            DataTable dt = new DataTable();
            string query = "SELECT id, nom, prenom, email, role FROM utilisateurs";


            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, GetConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);  // Remplit le DataTable avec les données de la BDD

                // Vérifier si la requête récupère bien des utilisateurs
                MessageBox.Show($"Requête SQL exécutée : {query}, Nombre de résultats : {dt.Rows.Count}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur SQL : {ex.Message}");
            }
            finally
            {
                CloseConnection();
            }

            return dt;
        }

        public static bool SupprimerUtilisateur(int utilisateurId)
        {
            string query = "DELETE FROM utilisateurs WHERE id = @id";

            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, GetConnection());
                cmd.Parameters.AddWithValue("@id", utilisateurId);
                int result = cmd.ExecuteNonQuery(); // Exécute la suppression
                return result > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la suppression de l'utilisateur : " + ex.Message);
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }


        public static bool ChangerRoleUtilisateur(int utilisateurId, string nouveauRole)
        {
            string query = "UPDATE utilisateurs SET role = @role WHERE id = @id";

            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, GetConnection());
                cmd.Parameters.AddWithValue("@role", nouveauRole);
                cmd.Parameters.AddWithValue("@id", utilisateurId);
                int result = cmd.ExecuteNonQuery(); // Met à jour le rôle
                return result > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la modification du rôle : " + ex.Message);
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }

        public static int GetNombreUtilisateurs()
        {
            string query = "SELECT COUNT(*) FROM utilisateurs";
            int nombre = 0;

            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, GetConnection());
                nombre = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors du comptage des utilisateurs : " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return nombre;
        }

        public static int GetNombreEvenements()
        {
            string query = "SELECT COUNT(*) FROM evenements";
            int nombre = 0;

            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, GetConnection());
                nombre = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors du comptage des événements : " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return nombre;
        }

        public static double GetTauxParticipation()
        {
            string totalParticipantsQuery = "SELECT COUNT(DISTINCT utilisateur_id) FROM inscriptions";
            string totalUtilisateursQuery = "SELECT COUNT(*) FROM utilisateurs";

            double taux = 0;

            try
            {
                OpenConnection();

                MySqlCommand cmdTotalParticipants = new MySqlCommand(totalParticipantsQuery, GetConnection());
                int totalParticipants = Convert.ToInt32(cmdTotalParticipants.ExecuteScalar());

                MySqlCommand cmdTotalUtilisateurs = new MySqlCommand(totalUtilisateursQuery, GetConnection());
                int totalUtilisateurs = Convert.ToInt32(cmdTotalUtilisateurs.ExecuteScalar());

                if (totalUtilisateurs > 0)
                {
                    taux = (double)totalParticipants / totalUtilisateurs;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors du calcul du taux de participation : " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return taux;
        }


        public static string GetEmailUtilisateur(int utilisateurId)
        {
            string email = "";
            string query = "SELECT email FROM utilisateurs WHERE id = @id";

            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, GetConnection());
                cmd.Parameters.AddWithValue("@id", utilisateurId);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    email = result.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la récupération de l'email : " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return email;
        }


        public static bool ModifierUtilisateur(int utilisateurId, string nouveauNom, string nouveauPrenom, string nouvelEmail, string nouveauMdp)
        {
            string query;
            MySqlCommand cmd;

            try
            {
                OpenConnection();

                if (string.IsNullOrWhiteSpace(nouveauMdp))
                {
                    // Mise à jour sans modifier le mot de passe
                    query = "UPDATE utilisateurs SET nom = @Nom, prenom = @Prenom, email = @Email WHERE id = @Id";
                    cmd = new MySqlCommand(query, GetConnection());
                }
                else
                {
                    // Mise à jour avec le mot de passe
                    query = "UPDATE utilisateurs SET nom = @Nom, prenom = @Prenom, email = @Email, mdp = @MotDePasse WHERE id = @Id";
                    cmd = new MySqlCommand(query, GetConnection());
                    cmd.Parameters.AddWithValue("@MotDePasse", nouveauMdp);
                }

                // Ajout des paramètres
                cmd.Parameters.AddWithValue("@Nom", nouveauNom);
                cmd.Parameters.AddWithValue("@Prenom", nouveauPrenom);
                cmd.Parameters.AddWithValue("@Email", nouvelEmail);
                cmd.Parameters.AddWithValue("@Id", utilisateurId);

                int result = cmd.ExecuteNonQuery();
                CloseConnection();

                return result > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la mise à jour : " + ex.Message);
                return false;
            }
        }


        public static string[] GetInfosUtilisateur(int utilisateurId)
        {
            string query = "SELECT nom, prenom, email FROM utilisateurs WHERE id = @id";
            string[] infos = new string[3];

            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, GetConnection());
                cmd.Parameters.AddWithValue("@id", utilisateurId);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) // Si on trouve l'utilisateur
                {
                    infos[0] = reader["nom"].ToString();    // Nom
                    infos[1] = reader["prenom"].ToString(); // Prénom
                    infos[2] = reader["email"].ToString();  // Email
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors de la récupération des infos utilisateur : {ex.Message}");
            }
            finally
            {
                CloseConnection();
            }

            return infos;
        }



    }
}
