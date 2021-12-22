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
    public class BLLRecibo
    {
        MPPRecibo Map = new MPPRecibo();

        public void Alta_Recibo(EERecibo Recibo)
        {
            Map.Alta_Recibo(Recibo);
        }

        public List<EERecibo> ListarRecibo()
        {
            return Map.ListarRecibo();
        }

        public EERecibo BuscarID(int id)
        {
            return Map.BuscarID(id);
        }
        public void CambiarEstadoVenta(int id)
        {
            Map.CambiarEstadoVenta(id);
        }
    }
}
