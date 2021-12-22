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
    public class BLLNotaDeCredito
    {
        MPPNotaDeCredito Map = new MPPNotaDeCredito();

        public void Alta_Nota_Credito(EENotaDeCredito NotaCre)
        {
            Map.Alta_Nota_Credito(NotaCre);
        }

        public List<EENotaDeCredito> ListarNotaCredito()
        {
            return Map.ListarNotaCredito();
        }

        public EENotaDeCredito BuscarID(int id)
        {
            return Map.BuscarID(id);
        }
    }
}
