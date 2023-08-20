using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ClienteDA
    {
        private readonly ConnectionManager _connectionManager = new ConnectionManager();


        public Cliente cargarClientePorID(string id)
        {
            Cliente cliente = new Cliente();

            using (SqlConnection conn = _connectionManager.getConnection())
            {
                conn.Open();

                string sqlQuery = "Select * from clientes where cedula='" +id+ "'";

                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))  //query y conexion
                {

                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read()) //pregunta .Read si hay algo
                    {
                        cliente = new Cliente
                        {
                            Cedula = Convert.ToString(dataReader["cedula"]),
                            Nombre = Convert.ToString(dataReader["nombre"]),
                            Apellido1 = Convert.ToString(dataReader["apellido1"]),
                            Apellido2 = Convert.ToString(dataReader["apellido2"]),
                            Email = Convert.ToString(dataReader["email"]),
                            Telefono = Convert.ToString(dataReader["telefono"]) ,
                            Direccion = Convert.ToString(dataReader["direccion"]) 

                        };
                    };
                };
            }
            return cliente;
        }


        public int cargarNumeroClientes()
        {
            int total = 0;
            using (SqlConnection conn = _connectionManager.getConnection())
            {
                conn.Open();

                string sqlQuery = "Select count(*) as total from clientes";

                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))  //query y conexion
                {

                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read()) //pregunta .Read si hay algo
                    {
                        total = Convert.ToInt32(dataReader["total"]);
                    }
                };
            }
            return total;
        }
    }
}
