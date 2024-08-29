using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace plannificationCours.back.core
{
    internal interface IDatabase
    {
        void OpenConnexion();
        void CloseConnexion();
        int ExecuteUpdate(string sql);
        DataTable ExecuteSelect(string sql);



    }
}
