using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plannificationCours.back.data.entities
{
    public class Role
    {

        private int id;
        private string libelle;
       

        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }

    }
}
