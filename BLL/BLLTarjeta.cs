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
    public class BLLTarjeta
    {
        MPPTarjeta Map = new MPPTarjeta();

        public EETarjetas BuscarNumero(int numero, int codigo)
        {
            return Map.BuscarNumero(numero,codigo);
        }

    }
}
