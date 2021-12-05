using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EE;
using MPP;

namespace BLL
{
    public class BLLEnum
    {
        public static List<EEEnum> ObtenerEnum(int constante)

        {
            MPPEnum MPPEnum = new MPPEnum();
            return MPPEnum.ObtenerEnum(constante);
        }
    }
}
