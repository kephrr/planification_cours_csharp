using plannificationCours.back.core.impl;
using plannificationCours.back.data.entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;


namespace plannificationCours.back.data.repositories.impl
{
    public class UserRepository : Database, IUserRepository
    {

        public static UserRepository userRepository = null;

        private UserRepository() { }
        public static UserRepository GetInstance()
        {
            if (userRepository == null)
            {
                userRepository = new UserRepository();
            }
            return userRepository;
        }

        public int Add(User entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public User FindById(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable findUserByLogin(string login)
        {
            string SQL_ALL = String.Format("select u.*,r.* from users u, roles r where u.id_role=r.role_id and u.login = '{0}'", login);
            tableName = "all_users";
            DataTable datatable = ExecuteSelect(SQL_ALL);
            return datatable;
        }

        public int Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
