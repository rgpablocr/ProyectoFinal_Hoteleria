using DataAccess;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ClienteBL
    {
        private ClienteDA _clienteDa= new ClienteDA();

        public Cliente cargarClientePorID(string id)
        {
            return _clienteDa.cargarClientePorID(id);
        }

        public int cargarNumeroClientes()
        {
            return _clienteDa.cargarNumeroClientes();
        }

    }
}
