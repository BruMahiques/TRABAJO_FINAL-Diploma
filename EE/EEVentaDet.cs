using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EE
{
    public class EEVentaDet
    {
        public int Id_Det { get; set; }
        public int Id_Producto_Det { get; set; }
        public int Id_Venta_Det { get; set; }
        public float Precio_Prod_Det { get; set; }
        public int Cantidad_Det { get; set; }
        public float Total_Det { get; set; }
    }
}
