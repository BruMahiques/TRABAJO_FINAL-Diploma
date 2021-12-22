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
    public class BLLNotaDeCreditoDet
    {
        MPPNotaDeCreditoDet Map = new MPPNotaDeCreditoDet();

        public void Alta_NotaCredito_Det(EENotaDeCreditoDet NotaCredito_Det)
        {
            Map.Alta_NotaCredito_Det(NotaCredito_Det);
        }
        public List<EENotaDeCreditoDet> ListarNotaDeCreditoDet(int id)
        {
            return Map.ListarNotaDeCreditoDet(id);
        }
    }
}
