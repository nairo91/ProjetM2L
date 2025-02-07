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
        public static bool InscrireUtilisateur(string email, string motDePasse)
        {
            string query = "INSERT INTO utilisateurs (email, mdp) VALUES (@mail, @mdp)";

            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@mail", email);
                cmd.Parameters.AddWithValue("@mdp", motDePasse);
                int result = cmd.ExecuteNonQuery();
                CloseConnection();
                return result > 0;  // Si l'insertion est réussie (plus de 0 lignes affectées), retourner vrai
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
            string query = "SELECT id, email, role FROM utilisateurs"; // On sélectionne les infos importantes

            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, GetConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);  // Remplit le DataTable avec les données de la BDD
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la récupération des utilisateurs : " + ex.Message);
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

    }
}
