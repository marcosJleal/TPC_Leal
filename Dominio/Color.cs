﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
   public class Color
    {
        public Int32 IdColor { get; set; }
        public string Nombre { get; set; }
        public int? Cantidad { get; set; }
        public override string ToString()
        {
            return Nombre;
        }
    }
}