﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EE
{
    public class EENotaDeCreditoDet
    {
        public int Id_NotaDeCredito { get; set; }

        public EEProducto Producto { get; set; }

        public int Cantidad { get; set; }

        public float Sub_total { get; set; }
    }
}
