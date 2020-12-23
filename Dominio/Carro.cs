using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Carro
    {
        public int Id { get; set; } 
        public List<ItemCarro> listaItems  { get; set; }
        public decimal Subtotal { get; set; }
    }
}
