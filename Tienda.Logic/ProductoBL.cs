using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda.Core;
using Tienda.Data;

namespace Tienda.Logic
{
    public class ProductoBL
    {
        public static List<Producto> Listar()
        {
            using(var db = new TiendaEntities())
            {
                return db.Producto.ToList();
            }
        }
    }
}
