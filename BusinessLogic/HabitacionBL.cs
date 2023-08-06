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
    }
}
