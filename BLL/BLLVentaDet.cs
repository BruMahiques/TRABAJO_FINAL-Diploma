using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EE;
using MPP;
using System.Data;

namespace BLL
{
    public class BLLVentaDet
    {
        MPPVenta Map = new MPPVenta();

        public void Alta_Venta_Det(EEVentaDet VentaDet)
        {
            Map.Alta_Venta_Det(VentaDet);
        }

        public List<EEVentaDet> ListarVentaDet()
        {
            return Map.ListarVentaDet();
        }

        public void Stock_Producto(EEVentaDet VentaDet)
        {
            Map.Stock_Producto(VentaDet);
        }
    }
}
