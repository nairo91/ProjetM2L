using System;

namespace AppLegeayControles
{
    internal class Evenement
    {
        private int id;
        private string nom;
        private DateTime date;
        private string lieu;
        private string description;
        private int? nbMaxParticipants;

        public Evenement() { }

        public Evenement(int id, string nom, DateTime date, string lieu, string description, int? nbMaxParticipants)
        {
            this.id = id;
            this.nom = nom;
            this.date = date;
            this.lieu = lieu;
            this.description = description;
            this.nbMaxParticipants = nbMaxParticipants;
        }

        public int GetId() { return id; }
        public void SetId(int value) { id = value; }

        public int Id
        {
            get { return GetId(); }
        }


        public string GetNom() { return nom; }
        public void SetNom(string value) { nom = value; }

        public DateTime GetDate() { return date; }
        public void SetDate(DateTime value) { date = value; }

        public string GetLieu() { return lieu; }
        public void SetLieu(string value) { lieu = value; }

        public string GetDescription() { return description; }
        public void SetDescription(string value) { description = value; }

        public int? GetNbMaxParticipants() { return nbMaxParticipants; }
        public void SetNbMaxParticipants(int? value) { nbMaxParticipants = value; }
    }
}


