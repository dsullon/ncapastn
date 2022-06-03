using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tienda.Logic;

namespace Tienda.AppWeb.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult Index()
        {
            var listado = ProductoBL.Listar();
            return View(listado);
        }

        public ActionResult Listar()
        {
            var listado = ProductoBL.Listar();
            return View(listado);
        }

        public ActionResult Editar(int id)
        {
            var producto = ProductoBL.ObtenerPorId(id);
            return View(producto);
        }
    }
}