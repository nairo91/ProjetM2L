using System;

namespace AppLegeayControles
{
    // Déclaration de la classe Utilisateurs
    internal class Utilisateurs
    {
        // Propriétés pour représenter un utilisateur
        public int Id;             // Identifiant unique de l'utilisateur
        public string Nom;       // Nom de l'utilisateur
        public string Email;      // Email de l'utilisateur
        public string MotDePasse;  // Mot de passe de l'utilisateur

        // Constructeur par défaut (sans paramètre)
        public Utilisateurs()
        {
        }

        // Constructeur pour initialiser un utilisateur avec des informations
        public Utilisateurs(int id, string nom, string email, string motDePasse)
        {
            Id = id;
            Nom = nom;
            Email = email;
            MotDePasse = motDePasse;
        }

      
    }
}
