using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TuSuper.Web.Models;

namespace TuSuper.Web.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult Index()
        {

            var producto1 = new ProductoModel();
            producto1.Id = 1;
            producto1.Descripcion = "Arroz";

            var producto2 = new ProductoModel();
            producto2.Id = 2;
            producto2.Descripcion = "Manzana";

            var producto3 = new ProductoModel();
            producto3.Id = 3;
            producto3.Descripcion = "Coca Cola";


            var listadeProductos = new List<ProductoModel>();
            listadeProductos.Add(producto1);
            listadeProductos.Add(producto2);
            listadeProductos.Add(producto3);

            return View(listadeProductos);
        }
    }
}