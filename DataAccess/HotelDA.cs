using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class HotelDA
    {
        private readonly ConnectionManager _connectionManager = new ConnectionManager();

        public List<Hotel> cargarHoteles()
        {
            List<Hotel> hoteles = new List<Hotel>();

            using (SqlConnection conn = _connectionManager.getConnection())
            {
                conn.Open();

                const string sqlQuery = "Select * from hoteles order by codhotel ASC";

                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))  //query y conexion
                {

                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read()) //pregunta .Read si hay algo
                    {
                        Hotel hotel = new Hotel
                        {
                            CodHotel = Convert.ToString(dataReader["codhotel"]),
                            Direccion = Convert.ToString(dataReader["direccion"]),
                            Nombre = Convert.ToString(dataReader["nombre"]),
                            Telefono = Convert.ToString(dataReader["telefono"])
                        };

                        hoteles.Add(hotel);

                    };
                }
            }

            return hoteles;
        }

    }
}
