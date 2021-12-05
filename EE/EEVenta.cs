using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EE
{
    public class EEVenta
    {
        public int Id_Venta { get; set; }

        public string Cod_Comprobante { get; set; }
        public int Id_TipoDePago { get; set; }

        public int Id_TipoDeDoc { get; set; }
        public int Id_TipoDeComprobante { get; set; }

        public DateTime Fecha { get; set; }
        public string Estado { get; set; }
        public int Id_Cliente_Venta { get; set; }
        public float Total_Venta { get; set; }

        public EEVenta() { }
    }
}
