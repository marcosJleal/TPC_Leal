using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Detalle
    {
        public Int32 ID { get; set; }
        public ItemCarro item { get; set; }
        public Pedido pedido { get; set; }

    }
}
