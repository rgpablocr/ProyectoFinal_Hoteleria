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
        public string Soleada { get; set; }
        public string Lavado { get; set; }
        public string Nevera { get; set; }
        public string Categoria { get; set; }

        public decimal PrecioFinal { get; set; }

    }
}
