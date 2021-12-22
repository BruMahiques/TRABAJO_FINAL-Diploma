using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EE;
using MPP;

namespace BLL
{
    public class BLLTipoDePago
    {
        
        MPPTipoDePago Map = new MPPTipoDePago();

        public EETipoDePago BuscarID(int id)
        {
           return Map.BuscarID(id);
        }
        public List<EETipoDePago> ListarTipoDePago()
        {
            return Map.ListarTipoDePago();
        }


    }
}
