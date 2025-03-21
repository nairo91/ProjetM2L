using System;

namespace AppLegeayControles
{
    internal class Utilisateurs
    {
        // Attributs privés
        private int id;
        private string nom;
        private string email;
        private string motDePasse;

        // Constructeur par défaut
        public Utilisateurs()
        {
        }

        // Constructeur avec paramètres
        public Utilisateurs(int id, string nom, string email, string motDePasse)
        {
            this.id = id;
            this.nom = nom;
            this.email = email;
            this.motDePasse = motDePasse;
        }

        // Getters et Setters explicites
        public int GetId()
        {
            return id;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public string GetNom()
        {
            return nom;
        }

        public void SetNom(string nom)
        {
            this.nom = nom;
        }

        public string GetEmail()
        {
            return email;
        }

        public void SetEmail(string email)
        {
            this.email = email;
        }

        public string GetMotDePasse()
        {
            return motDePasse;
        }

        public void SetMotDePasse(string motDePasse)
        {
            this.motDePasse = motDePasse;
        }
    }
}


