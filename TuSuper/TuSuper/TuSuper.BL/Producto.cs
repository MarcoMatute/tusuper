using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuSuper.BL
{
    public class Producto
    {
        public Producto()
        {
            Activo = true;
        }

        public int Id { get; set; }

        [Display(Name ="Descripción")]
        [Required(ErrorMessage ="Ingrese la Descripcion")]
        [MinLength(3,ErrorMessage ="Ingrese Minimo 3 Caracteres" )]
        [MaxLength(20,ErrorMessage ="Ingrese un Maximo de 20 Caracteres")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage ="Ingrese Precio")]
        [Range (0,10000,ErrorMessage ="Ingrese un Precio entre 0 y 10,000")]
        public double Precio { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

        [Display(Name ="Imagen")]
        public string UrlImagen { get; set; }

        public bool Activo { get; set; }
    }
}
