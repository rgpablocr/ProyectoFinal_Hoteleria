using DataAccess;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ReservacionBL
    {

        private ReservacionDA _reservacionDA = new ReservacionDA();


        public List<Reservacion> cargarReservacionesPorCliente(string cedula)
        {
            return _reservacionDA.cargarReservacionesPorCliente(cedula);
        }
        public Reservacion cargarReservacionesPorId(string id)
        {
            return _reservacionDA.cargarReservacionesPorId(id);
        }

        public int cargarNumeroReservaciones()
        {
            return _reservacionDA.cargarNumeroReservaciones();
        }

        }
}
