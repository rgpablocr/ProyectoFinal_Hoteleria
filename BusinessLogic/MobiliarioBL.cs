using DataAccess;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class MobiliarioBL
    {
        private MobiliarioDA mobiliarioDA = new MobiliarioDA();

        public List<MobiliarioHabitacion> cargarMobililarioPorHabitacion(int id)
        {
            return mobiliarioDA.cargarMobililarioPorHabitacion(id);
        }

        public MobiliarioHabitacion cargarMobililarioPorId(int id)
        {
            return mobiliarioDA.cargarMobililarioPorId(id);
        }
        public int cambiarMobililarioHabitacion(int codigo, int codHabitacionNueva, int codMobiliario)
        {
            return mobiliarioDA.cambiarMobililarioHabitacion(codigo, codHabitacionNueva, codMobiliario);
        }


    }
}
