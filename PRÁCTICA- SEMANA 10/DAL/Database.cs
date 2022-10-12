using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using PRÁCTICA__SEMANA_10.Properties;
using System.Configuration;

namespace PRÁCTICA__SEMANA_10.DAL
{
    public class Database
    {
        public static string getStrConnection()
        {
            return Settings.Default.empleadosConnectionString;
        }

        public SqlConnection getConnection()
        {
            SqlConnection Con = new SqlConnection(getStrConnection());
            return Con;
        }

        public bool testConection()
        {
            SqlConnection Con = this.getConnection();
            Con.Open();
            if (Con.State == System.Data.ConnectionState.Open)
            {
                Con.Close();
                return true;
            }
            else
            {
                return false;
            }


        }
    }
}

