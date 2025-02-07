using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLegeayControles
{
    internal class Evenement
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public DateTime Date { get; set; }
        public string Lieu { get; set; }
        public string Description { get; set; }
        public int? NbMaxParticipants { get; set; }

        public Evenement() { }

        public Evenement(int id, string nom, DateTime date, string lieu, string description, int? nbMaxParticipants)
        {
            Id = id;
            Nom = nom;
            Date = date;
            Lieu = lieu;
            Description = description;
            NbMaxParticipants = nbMaxParticipants;
        }
    }
}
