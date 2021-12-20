using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EE;
using MPP;

namespace BLL
{
    public class BLLTipoDeComprobante
    {
        MPPTipoDeComprobante Map = new MPPTipoDeComprobante();

        public EETipoDeComprobante BuscarID(int id)
        {
           return Map.BuscarID(id);
        }
    }
}
