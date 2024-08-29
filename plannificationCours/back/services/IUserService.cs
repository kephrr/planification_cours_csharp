using plannificationCours.back.data.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plannificationCours.back.services
{
    public interface IUserService
    {
        User Connexion(string login, string password);
       
    }
}
