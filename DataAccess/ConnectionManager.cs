using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ConnectionManager
    {

        //private readonly string _connectionString;

        //public ConnectionManager(string connectionString)
        //{
        //    this._connectionString = connectionString;
        //}

        public SqlConnection getConnection()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ConnectionString);
        }

    }
}
