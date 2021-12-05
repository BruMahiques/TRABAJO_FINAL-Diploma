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
    public class BLLVenta
    {
        MPPVenta Map = new MPPVenta();

        public void Alta_Venta(EEVenta Venta)
        {
            Map.Alta_Venta(Venta);
        }

        public List<EEVenta> ListarVenta()
        {
            return Map.ListarVenta();
        }
    }
}
