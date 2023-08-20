using DataAccess;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class HabitacionBL
    {

        private HabitacionDA _habitacionDA = new HabitacionDA();

        public List<Habitacion> cargarHabitacionPorHotel(string id)
        {
            return _habitacionDA.cargarHabitacionPorHotel(id);
        }

        public Habitacion cargarHabitacionPorId(string id)
        {
            return _habitacionDA.cargarHabitacionPorId(id);
        }
        public List<Habitacion> cargarHabitaciones(int id)
        {
            return _habitacionDA.cargarHabitaciones(id);
        }
        public void actualizarPrecioHabitacion(int id)
        {
            _habitacionDA.actualizarPrecioHabitacion(id);
        }

        public Habitacion cargarHotelPorHabitacion(int id)
        {
            return _habitacionDA.cargarHotelPorHabitacion(id);
        }

        public int cargarNumeroHabitaciones()
        {
            return _habitacionDA.cargarNumeroHabitaciones();
        }

    }
}
