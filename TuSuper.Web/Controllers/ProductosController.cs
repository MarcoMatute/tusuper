using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TuSuper.BL;

namespace TuSuper.Web.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Producto
        public ActionResult Index()
        {
            var productosBL = new ProductosBL();
            var listadeProductos = productosBL.ObtenerProducutos();

            return View(listadeProductos);
        }
    }
}