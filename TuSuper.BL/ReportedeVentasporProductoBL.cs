using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuSuper.BL
{
    public class ReportedeVentasporProductoBL
    {
        Contexto _contexto;
        public List<ReporteVentasporProducto> ListadeVentasPorProdcuto { get; set; }

        public ReportedeVentasporProductoBL()
        {
            _contexto = new Contexto();
            ListadeVentasPorProdcuto = new List<ReporteVentasporProducto>();
        }

        public List<ReporteVentasporProducto> ObtenerVentasPorProdcuto()
        {
            ListadeVentasPorProdcuto = _contexto.OrdenDetalle
                .Include("Producto")
                .Where(r => r.Orden.Activo)
                .GroupBy(r => r.Producto.Descripcion)
                .Select(r => new ReporteVentasporProducto()
                {
                    Producto = r.Key,
                    Cantidad = r.Sum( s => s.Cantidad),
                    Total = r.Sum( s => s.Total)
                }).ToList();

            return ListadeVentasPorProdcuto;
        }
    }
}
