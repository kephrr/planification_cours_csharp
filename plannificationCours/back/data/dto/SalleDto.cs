using plannificationCours.back.data.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plannificationCours.back.data.dto
{
    public class SalleDto
    {
        private int id;
        private string libelle;

        public SalleDto(Salle salle)
        {
            this.Id = salle.Id;
            this.Libelle = salle.Libelle;
          
        }

        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }
    }
}
