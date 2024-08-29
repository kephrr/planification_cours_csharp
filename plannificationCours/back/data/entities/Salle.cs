using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plannificationCours.back.data.entities
{
    public class Salle
    {
        private int id;
        private string libelle;
        private bool etat;

        public Salle()
        {
        }

        public Salle(string libelle, bool etat)
        {
            Libelle = libelle;
            Etat = etat;
        }

        public Salle(int id, string libelle, bool etat)
        {
            Id = id;
            Libelle = libelle;
            Etat = etat;
        }

        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        public bool Etat { get => etat; set => etat = value; }
    }
}
