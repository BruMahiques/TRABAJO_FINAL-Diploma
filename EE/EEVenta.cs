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

        public EETipoDePago TipoDePago { get; set; }
            
        public List<EEVentaDet> LDetalle { get; set; }

        public DateTime Fecha { get; set; }
        public string Estado { get; set; }
        public EECliente Cliente { get; set; }
        public float Total_Venta { get; set; }

        public EEVenta() { }
        public override string ToString()
        {
            return Id_Venta  + " / " + Cod_Comprobante;
        }

    }
}
