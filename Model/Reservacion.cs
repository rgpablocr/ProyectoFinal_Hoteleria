using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Reservacion
    {
        public string CodReservacion { get; set; }
        public string Cedula { get; set; }
        public DateTime FechaLlegada { get; set; }
        public DateTime FechaSalida { get; set; }
        public int CodHabitacion { get; set; }
        public string MetodoPago { get; set; }
    }
}
