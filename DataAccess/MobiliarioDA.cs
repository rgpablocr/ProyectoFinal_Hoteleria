using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MobiliarioDA
    {

        private readonly ConnectionManager _connectionManager = new ConnectionManager();

        public List<MobiliarioHabitacion> cargarMobililarioPorHabitacion(int id)
        {
            List<MobiliarioHabitacion> mobiliarios = new List<MobiliarioHabitacion>();

            using (SqlConnection conn = _connectionManager.getConnection())
            {
                conn.Open();

                string sqlQuery = "Select h.codigo, h.codhabitacion, h.codmobiliario, m.descripcion, m.precio from mobiliario_habitaciones h INNER JOIN mobiliario m on h.codmobiliario = m.codmobiliario where h.codhabitacion=" + id+"";

                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))  //query y conexion
                {

                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read()) //pregunta .Read si hay algo
                    {
                        MobiliarioHabitacion mobiliario = new MobiliarioHabitacion
                        {
                            Codigo = Convert.ToInt32(dataReader["codigo"]),
                            CodHabitacion = Convert.ToInt32(dataReader["codhabitacion"]),
                            CodMobiliario = Convert.ToInt32(dataReader["codmobiliario"]),
                            Descripcion = Convert.ToString(dataReader["descripcion"]),
                            Precio = Convert.ToDecimal(dataReader["precio"]),
                        };
                        mobiliarios.Add(mobiliario);
                    };
                };
            }
            return mobiliarios;
        }

        public MobiliarioHabitacion cargarMobililarioPorId(int id)
        {
            MobiliarioHabitacion mobiliario = new MobiliarioHabitacion();

            using (SqlConnection conn = _connectionManager.getConnection())
            {
                conn.Open();

                string sqlQuery = "Select h.codigo, h.codhabitacion, h.codmobiliario, m.descripcion, m.precio from mobiliario_habitaciones h INNER JOIN mobiliario m on h.codmobiliario = m.codmobiliario where h.codigo=" + id + "";

                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))  //query y conexion
                {

                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read()) //pregunta .Read si hay algo
                    {
                        mobiliario = new MobiliarioHabitacion
                        {
                            Codigo = Convert.ToInt32(dataReader["codigo"]),
                            CodHabitacion = Convert.ToInt32(dataReader["codhabitacion"]),
                            CodMobiliario = Convert.ToInt32(dataReader["codmobiliario"]),
                            Descripcion = Convert.ToString(dataReader["descripcion"]),
                            Precio = Convert.ToDecimal(dataReader["precio"]),
                        };

                    };
                };
            }
            return mobiliario;
        }

        //cambiar de habitacion el mobiliario
        public int cambiarMobililarioHabitacion(int codigo, int codHabitacionNueva, int codMobiliario)
        {
            int status = 0;

            using (SqlConnection conn = _connectionManager.getConnection())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("usp_TrasladoMobiliarioHabitacion", conn))  //query y conexion
                {

                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("Codigo", codigo);
                    cmd.Parameters.AddWithValue("CodHabitacionNueva", codHabitacionNueva);
                    cmd.Parameters.AddWithValue("CodMobiliario", codMobiliario);
                    SqlParameter output = cmd.Parameters.Add("@Status", System.Data.SqlDbType.Int);
                    output.Direction = System.Data.ParameterDirection.Output;
                    cmd.ExecuteNonQuery();

                    status = Convert.ToInt32(cmd.Parameters["@Status"].Value);

                };
            }
            return status;
        }


    }
}
