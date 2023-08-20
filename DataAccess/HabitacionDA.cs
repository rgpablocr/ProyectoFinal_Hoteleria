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

        public List<Habitacion> cargarHabitaciones(int id)
        {
            List<Habitacion> habitaciones = new List<Habitacion>();

            using (SqlConnection conn = _connectionManager.getConnection())
            {
                conn.Open();

                string sqlQuery = "Select codhabitacion, codhotel from habitaciones where codhabitacion <> " +id ;

                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))  //query y conexion
                {

                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read()) //pregunta .Read si hay algo
                    {
                        Habitacion habitacion = new Habitacion
                        {
                            CodHabitacion = Convert.ToInt32(dataReader["codhabitacion"]),
                            CodHotel = Convert.ToString(dataReader["codhotel"]),
                            
                        };
                        habitaciones.Add(habitacion);
                    };
                };
            }
            return habitaciones;
        }

        public void actualizarPrecioHabitacion(int id)
        {
            using (SqlConnection conn = _connectionManager.getConnection())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("usp_ModificarPrecioHabitacion", conn))  //query y conexion
                {

                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("CodHabitacion", id);

                    cmd.ExecuteNonQuery();

                };
            }
        }

        public Habitacion cargarHotelPorHabitacion(int id)
        {
            Habitacion habitacion = new Habitacion();

            using (SqlConnection conn = _connectionManager.getConnection())
            {
                conn.Open();

                string sqlQuery = "Select  h.codhotel from habitaciones h where h.codhabitacion = " + id + "";

                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))  //query y conexion
                {

                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read()) //pregunta .Read si hay algo
                    {
                        habitacion = new Habitacion
                        {
                            CodHotel = Convert.ToString(dataReader["codhotel"])
                        };
                    };
                };
            }
            return habitacion;
        }

        public int cargarNumeroHabitaciones()
        {
            int total = 0;
            using (SqlConnection conn = _connectionManager.getConnection())
            {
                conn.Open();

                string sqlQuery = "SELECT COUNT(DISTINCT codhabitacion) AS total FROM reservaciones";

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
