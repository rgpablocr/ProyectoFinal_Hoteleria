using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Habitacion
    {
        public int CodHabitacion { get; set; }
        public string CodHotel { get; set; }
        public bool Soleada { get; set; }
        public bool Lavado { get; set; }
        public bool Nevera { get; set; }
        public int CodCategoria { get; set; }
    }
}
