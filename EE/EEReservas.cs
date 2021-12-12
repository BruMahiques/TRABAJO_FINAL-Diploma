using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EE
{
    public class EEReservas
    {
        public int Id_Reserva { get; set; }

        public string Cod_Comprobante { get; set; }
        public int Id_TipoDePago { get; set; }

        public int Id_TipoDeDoc { get; set; }
   
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }
        public int Id_Cliente_Reserva { get; set; }
        public float Seña { get; set; }
        public float Total { get; set; }

        public EEReservas() { }
    }
}
