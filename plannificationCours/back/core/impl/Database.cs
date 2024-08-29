using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace plannificationCours.back.core.impl
{
    public class Database : IDatabase
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["plannif_cour"].ConnectionString;
        private SqlConnection sqlConnection = new SqlConnection();

        private SqlDataAdapter adapter = new SqlDataAdapter();
        protected string tableName;
        public void CloseConnexion()
        {
            if(sqlConnection.State == ConnectionState.Open || sqlConnection.State == ConnectionState.Connecting)
            {
                sqlConnection.Close();
            }
           
        }

        public DataTable ExecuteSelect(string sql)
        {
            try
            {
                OpenConnexion();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = sql;
                adapter.SelectCommand = sqlCommand;
                DataSet plannif_cour = new DataSet();//Base de donnée
                if (plannif_cour.Tables[tableName] != null)
                {
                    plannif_cour.Tables[tableName].Clear();
                }
                adapter.Fill(plannif_cour, tableName);
                CloseConnexion();
                return plannif_cour.Tables[tableName];

            }
            catch(Exception e)
            {
                throw;
            }


        }

        public int ExecuteUpdate(string sql)
        {
            try
            {
                OpenConnexion();
                SqlCommand sqlCommand = new SqlCommand();
                int nbreLigne = 0;
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = sql;
                adapter.SelectCommand = sqlCommand;
                if (sql.ToLower().StartsWith("insert"))
                {
                    
                    //nbreLigne = Convert.ToInt32(sqlCommand.ExecuteScalar()); //vérifie là
                    nbreLigne = sqlCommand.ExecuteNonQuery();
                }
                else
                {
                    nbreLigne = sqlCommand.ExecuteNonQuery();
                }
                CloseConnexion();
                return nbreLigne;
            }
            catch (Exception e) { throw; }

        }

        public void OpenConnexion()
        {
            if(sqlConnection.State == ConnectionState.Closed || sqlConnection.State == ConnectionState.Broken)
            {
                sqlConnection.ConnectionString = connectionString;
                sqlConnection.Open();
            }
        }
    }
}
