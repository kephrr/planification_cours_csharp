using plannificationCours.back.data.entities;
using plannificationCours.back.data.repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace plannificationCours.back.services.impl
{
    public class UserService : IUserService
    {
        private static  IUserRepository repository;
        private static IUserService userService = null; 

        private UserService()
        {
        }


        private UserService(IUserRepository repositor)
        {
          repository = repositor;
        }
        public static IUserService getInstance(IUserRepository repository)
        {
            if(userService == null)
            {
                return new UserService(repository);

            }
            return userService;
            

        }

        public User Connexion(string login, string password)
        {
            User user = null;
            DataTable datatable = repository.findUserByLogin(login);
            if (datatable.Rows.Count != 0)
            {
                DataRow item = datatable.Rows[0];
                user = new User()
                {
                    Id = int.Parse(item.ItemArray[0].ToString()),
                    NomComplet = item.ItemArray[1].ToString(),
                    Login = item.ItemArray[2].ToString(),
                    Password = item.ItemArray[3].ToString(),
                    Etat =(bool)item.ItemArray[4],
                    Role = new Role()
                    {
                        Id = int.Parse(item.ItemArray[6].ToString()),
                        Libelle = item.ItemArray[7].ToString()

                    }

                };

            }
            if(user == null || password != user.Password)
            {
                return null;
            }
            else
            {
                return user;
            }      

        }
    }
}
