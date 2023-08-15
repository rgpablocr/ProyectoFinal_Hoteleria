using DataAccess;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class HotelBL
    {
        private HotelDA _hotelDA = new HotelDA();

        public List<Hotel> cargarHoteles()
        {
            return _hotelDA.cargarHoteles();
        }
        public Hotel cargarHotelPorId(string id)
        {
            return _hotelDA.cargarHotelPorId(id);
        }

    }
}
