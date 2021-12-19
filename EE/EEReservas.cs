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
         public EETipoDePago TipoDePago { get; set; }

        public EETipoDeDoc TipoDeDoc { get; set; }

        List<EEVentaDet> Detalle { get; set; }

        public DateTime Fecha { get; set; }
        public string Estado { get; set; }
        public EECliente Cliente { get; set; }
        public float Seña { get; set; }
        public float Total { get; set; }


        public EEReservas() { }
    }
}
