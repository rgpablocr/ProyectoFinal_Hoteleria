using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ReservacionDA
    {
        private readonly ConnectionManager _connectionManager = new ConnectionManager();

        public List<Reservacion> cargarReservacionesPorCliente(string cedula)
        {
            List<Reservacion> reservaciones = new List<Reservacion>();

            using (SqlConnection conn = _connectionManager.getConnection())
            {
                conn.Open();

                string sqlQuery = "Select r.codreservacion, r.cedula, r.fechallegada, r.fechasalida,r.codhabitacion, r.metodopago, r.cancelado from reservaciones r, clientes c where r.cedula = '"+cedula+"' and r.cedula = c.cedula order by r.fechallegada DESC";

                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))  //query y conexion
                {

                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read()) //pregunta .Read si hay algo
                    {
                        Reservacion reservacion = new Reservacion
                        {
                            CodReservacion = Convert.ToString(dataReader["codreservacion"]),
                            Cedula = Convert.ToString(dataReader["cedula"]),
                            FechaLlegada = Convert.ToDateTime(dataReader["fechallegada"]),
                            FechaSalida = Convert.ToDateTime(dataReader["fechasalida"]),
                            CodHabitacion = Convert.ToInt32(dataReader["codhabitacion"]),
                            MetodoPago = Convert.ToByte(dataReader["metodopago"]) == 0 ? "Efectivo" : "Tarjeta Crédito",
                            Cancelado = Convert.ToDecimal(dataReader["cancelado"]),
                        };
                        reservaciones.Add(reservacion);
                    };
                };
            }
            return reservaciones;
        }

        public Reservacion cargarReservacionesPorId(string id)
        {
           Reservacion reservacion = new Reservacion();

            using (SqlConnection conn = _connectionManager.getConnection())
            {
                conn.Open();

                string sqlQuery = "Select r.codreservacion, r.cedula, r.fechallegada, r.fechasalida,r.codhabitacion, r.metodopago, r.cancelado from reservaciones r where r.codreservacion = '" + id + "' order by r.fechallegada DESC";

                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))  //query y conexion
                {

                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read()) //pregunta .Read si hay algo
                    {
                        reservacion = new Reservacion
                        {
                            CodReservacion = Convert.ToString(dataReader["codreservacion"]),
                            Cedula = Convert.ToString(dataReader["cedula"]),
                            FechaLlegada = Convert.ToDateTime(dataReader["fechallegada"]),
                            FechaSalida = Convert.ToDateTime(dataReader["fechasalida"]),
                            CodHabitacion = Convert.ToInt32(dataReader["codhabitacion"]),
                            MetodoPago = Convert.ToByte(dataReader["metodopago"]) == 0 ? "Efectivo" : "Tarjeta Crédito",
                            Cancelado = Convert.ToDecimal(dataReader["cancelado"]),
                        };
                    };
                };
            }
            return reservacion;
        }

        public int cargarNumeroReservaciones()
        {
            int total = 0;
            using (SqlConnection conn = _connectionManager.getConnection())
            {
                conn.Open();

                string sqlQuery = "Select count(*) as total from reservaciones";

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
