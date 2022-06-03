using System.Collections.Generic;
using System.Linq;
using Tienda.Core;
using Tienda.Data;

namespace Tienda.Logic
{
    public class ClienteBL
    {
        public static List<Cliente> Listar()
        {
            using(var db = new TiendaEntities())
            {
                return db.Cliente.ToList();
            }
        }

        public static Cliente Buscar(int id)
        {
            using(var db = new TiendaEntities())
            {
                return db.Cliente.Find(id);
            }
        }
    }
}
