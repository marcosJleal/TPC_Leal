using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Carro
    {
        public int IdCarro { get; set; }
        public int IdUsuario { get; set; }
        public ItemCarro ItemCarro { get; set; }
        public decimal Subtotal { get; set; }
    }
}
