using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        public int IdArticulo { get; set; }
        public string Nombre { get; set; }
        public string Color { get; set; }
        public Categoria Categoria { get; set; }
        public int Stock { get; set; }
        public decimal Precio { get; set; }
        
        public bool Estado { get; set; }
        public string Descripcion { get; set; }
        public string UrlImagen { get; set; }
    }
}
