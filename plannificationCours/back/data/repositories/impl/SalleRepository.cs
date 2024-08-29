using plannificationCours.back.core.impl;
using plannificationCours.back.data.entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plannificationCours.back.data.repositories.impl
{
    public class SalleRepository : Database, ISalleRepository
    {
        private readonly string SQL_ALL = "select * from salles";
        private static SalleRepository salleRepository = null;

        private SalleRepository()
        {
        }
        public static SalleRepository GetInstance()
        {
            if(salleRepository == null)
            {
                return new SalleRepository();
            }
            return salleRepository;
        }

        public int Add(Salle entity)
        {
            string sql = string.Format("INSERT INTO salles ([libelle],[etat])  VALUES ('{0}','{1}')", entity.Libelle, entity.Etat);
            return ExecuteUpdate(sql);
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Salle FindById(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable GetAll()
        {
            tableName = "all_salles";
            return ExecuteSelect(SQL_ALL);

        }

        public int Update(Salle entity)
        {
            string sql = String.Format("UPDATE salles SET [libelle]= '{0}' where [salle_id] = '{1}' ", entity.Libelle, entity.Id);
            return ExecuteUpdate(sql);


        }
    }
}
