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
    public class NiveauRepository :  Database, INiveauRepository
    {
        private static NiveauRepository instance = null;
        private readonly string SQL_ALL = "SELECT * FROM niveaux";

        private NiveauRepository()
        {
        }

        public Database GetInstance()
        {
            if(instance == null)
            {
                instance = new NiveauRepository();
            }
            return instance;
        }

        public int Add(Niveau entity)
        {
            string sql = String.Format("INSERT INTO niveaux ([libelle])  VALUES ('{0}')", entity.Libelle);
            return ExecuteUpdate(sql);
        }

        public int Delete(int id)
        {
           
        }

        public Niveau FindById(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable GetAll()
        {
            tableName = "all_niveaux";
           return ExecuteSelect(SQL_ALL);
        }

        public int Update(Niveau entity)
        {
            string sql = String.Format("UPDATE niveaux SET [libelle] = {'0'} where [niveau_id] = {'1'}", entity.Libelle);
            return ExecuteUpdate(sql);
        }
    }
}
