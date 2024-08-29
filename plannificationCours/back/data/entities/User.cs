using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using plannificationCours.back.data.enums;

namespace plannificationCours.back.data.entities
{
    public class User
    {
        private int id;
        private string nomComplet;
        private string password;
        private string login;
        private bool etat;
        private Role role;

        public User()
        {
        }

        public User(string nomComplet, string password, string login, bool etat, Role role)
        {
            NomComplet = nomComplet;
            Password = password;
            Login = login;
            Etat = etat;
            Role = role;
        }

        public User(int id, string nomComplet, string password, string login, bool etat, Role role)
        {
            Id = id;
            NomComplet = nomComplet;
            Password = password;
            Login = login;
            Etat = etat;
            Role = role;
        }

        public int Id { get => id; set => id = value; }
        public string NomComplet { get => nomComplet; set => nomComplet = value; }
        public string Password { get => password; set => password = value; }
        public string Login { get => login; set => login = value; }
        public bool Etat { get => etat; set => etat = value; }
        public Role Role { get => role; set => role = value; }
    }
}
