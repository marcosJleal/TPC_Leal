using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
   public class Pedido
    {
        public Int64 ID { get; set; }
        public Carro Carro { get; set; }
        public Usuario Usuario { get; set; }
        public Estado Estado { get; set; }
        public DateTime Fecha { get; set; }
    }
}
