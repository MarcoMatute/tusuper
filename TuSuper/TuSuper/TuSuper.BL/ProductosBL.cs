using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuSuper.BL
{
    public class ProductosBL
    {

        Contexto _contexto;

        public ProductosBL()
        {
            _contexto = new Contexto();
        }


        public List<Producto> ObtenerProducutos()
        {

            return _contexto.Productos.ToList();
        }
            
    }
}
