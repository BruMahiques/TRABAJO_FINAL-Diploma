using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EE
{
    public class EEReservas
    {
        public int Cod_Cliente { get; set; }
        public int Cod_Producto { get; set; }
        public int Dias { get; set; }
        public double Importe { get; set; }
               
        public EEReservas() { }
    }
}
