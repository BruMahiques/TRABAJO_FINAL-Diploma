using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EE;
using MPP;

namespace BLL
{
    public class BLLTipoDeDoc
    {
        MPPTipoDeDoc Map = new MPPTipoDeDoc();

        public EETipoDeDoc BuscarID(int id)
        {
           return Map.BuscarID(id);
        }
    }
}
