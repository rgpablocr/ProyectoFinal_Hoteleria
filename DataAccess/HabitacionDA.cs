using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class HabitacionDA
    {
        private readonly ConnectionManager _connectionManager = new ConnectionManager();

        public Habitacion cargarHabitacionPorId(string id)
        {
            Habitacion habitacion = new Habitacion();

            using (SqlConnection conn = _connectionManager.getConnection())
            {
                conn.Open();

                string sqlQuery = "Select  h.codhabitacion, h.codhotel, h.soleada, h.lavado, h.nevera, c.categoria, h.preciofinal from habitaciones h, categoriahabitacion c where h.codhabitacion = " + id + " and h.codcategoria = c.codcategoria";

                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))  //query y conexion
                {

                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read()) //pregunta .Read si hay algo
                    {
                         habitacion = new Habitacion
                        {
                            CodHabitacion = Convert.ToInt32(dataReader["codhabitacion"]),
                            CodHotel = Convert.ToString(dataReader["codhotel"]),
                            Soleada = Convert.ToByte(dataReader["soleada"]) == 0 ? "Sí" : "No", 
                            Lavado = Convert.ToByte(dataReader["lavado"]) == 0 ? "Sí" : "No",
                            Nevera = Convert.ToByte(dataReader["nevera"]) == 0 ? "Sí" : "No",
                            Categoria = Convert.ToString(dataReader["categoria"]),
                            PrecioFinal = Convert.ToDecimal(dataReader["preciofinal"])
                        };
                    };
                };
            }
            return habitacion;
        }

        public List<Habitacion> cargarHabitacionPorHotel(string id)
        {
            List<Habitacion> habitaciones = new List<Habitacion>();

            using (SqlConnection conn = _connectionManager.getConnection())
            {
                conn.Open();

                string sqlQuery = "Select  h.codhabitacion, h.codhotel, h.soleada, h.lavado, h.nevera, c.categoria, h.preciofinal from habitaciones h, categoriahabitacion c where h.codhotel = '" + id + "' and h.codcategoria = c.codcategoria";

                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))  //query y conexion
                {

                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read()) //pregunta .Read si hay algo
                    {
                        Habitacion habitacion = new Habitacion
                        {
                            CodHabitacion = Convert.ToInt32(dataReader["codhabitacion"]),
                            CodHotel = Convert.ToString(dataReader["codhotel"]),
                            Soleada = Convert.ToByte(dataReader["soleada"]) == 0 ? "Sí" : "No",
                            Lavado = Convert.ToByte(dataReader["lavado"]) == 0 ? "Sí" : "No",
                            Nevera = Convert.ToByte(dataReader["nevera"]) == 0 ? "Sí" : "No",
                            Categoria = Convert.ToString(dataReader["categoria"]),
                            PrecioFinal = Convert.ToDecimal(dataReader["preciofinal"])
                        };
                        habitaciones.Add(habitacion);
                    };
                };
            }
            return habitaciones;
        }

    }
}
