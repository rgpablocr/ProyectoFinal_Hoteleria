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
        public SqlConnection getConnection()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ConnectionString);
        }

    }
}
