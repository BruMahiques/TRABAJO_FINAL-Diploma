using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICIOS.Inicio
{
    public class ExceptionLogin : Exception
    {
        public ResultadoLogin Result;

        public ExceptionLogin(ResultadoLogin result)
        {
            Result = result;
        }
    }
}
