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
    public class BLLReciboDet
    {
        MPPReciboDet Map = new MPPReciboDet();

        public void Alta_Recibo_Det(EEReciboDet ReciboDet)
        {
            Map.Alta_Recibo_Det(ReciboDet);
        }
        public List<EEReciboDet> ListarReciboDet(int id)
        {
            return Map.ListarReciboDet(id);
        }
    }
}
