using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class UsuarioDA
    {
        private readonly ConnectionManager _connectionManager = new ConnectionManager();
        public int loginUsuario(string id, string password)
        {
            int usuario = 0;

            using (SqlConnection conn = _connectionManager.getConnection())
            {
                conn.Open();

                string sqlQuery = "Select COUNT(*) as existe from usuarios r where nombreusuario = '" + id + "' and contrasena =  '" + password + "'";

                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))  //query y conexion
                {

                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read()) //pregunta .Read si hay algo
                    {
                        usuario = Convert.ToInt32(dataReader["existe"]);
                    };
                };
            }
            return usuario;
        }

        public string obtenerKey(string id)
        {
            string llave = "";

            using (SqlConnection conn = _connectionManager.getConnection())
            {
                conn.Open();

                string sqlQuery = "Select llave from usuarios r where nombreusuario = '" + id + "'";

                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))  //query y conexion
                {

                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read()) //pregunta .Read si hay algo
                    {
                        llave = Convert.ToString(dataReader["llave"]);
                    };
                };
            }
            return llave;
        }


    }
}
