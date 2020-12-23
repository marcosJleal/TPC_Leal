using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ItemCarro
    {
        public Articulo articulo { get; set; }
        public int Cantidad { get; set; }
        public decimal subtotal { get; set; }
        public Color Color { get; set; }
    }
}
