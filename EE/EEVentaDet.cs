﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EE
{
    public class EEVentaDet
    {
        public EEVenta Venta { get; set; }

        public EEProducto Producto { get; set; }
        
       public int Cantidad { get; set; }

        public float Sub_total { get; set; }
    }
}
