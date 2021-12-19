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

        public DataTable ListarVentaDet(string Id_Venta)
        {
            return Map.ListarVentaDet(Id_Venta);
        }

        public void Stock_Producto(EEVentaDet VentaDet)
        {
            Map.Stock_Producto(VentaDet);
        }
        public DataTable CargarGrafico(int num,string desde, string hasta)
        {
            return Map.CargarGrafico(num, desde , hasta);
        }
    }
}
