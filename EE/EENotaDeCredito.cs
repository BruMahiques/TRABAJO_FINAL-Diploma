using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EE
{
    public class EENotaDeCredito
    {
        public int Id_NotaDeCredito { get; set; }

        public EEVenta Venta { get; set; }

        public string Cod_Comprobante { get; set; }

        
        public List<EENotaDeCreditoDet> LDetalle { get; set; }

        public DateTime Fecha { get; set; }
        public string Estado { get; set; }
        public EECliente Cliente { get; set; }
        public float Total { get; set; }

        public EENotaDeCredito() { }
    }
}
