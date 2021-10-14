using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EE;
using Datos;

namespace SERVICIOS.Bitacora
{
    public class BitacoraBLL
    {
        BitacoraDAL bDal = new BitacoraDAL();
        public void NuevaActividad(BitacoraActividadEE nAct)
        {

            nAct.Fecha = DateTime.Now;

            if (Singleton.Instancia.Usuario != null)
            {
                nAct.Usuario.Id = Singleton.Instancia.Usuario.Id;
            }
            bDal.NuevaActividad(nAct);
        }

        public List<BitacoraActividadEE> ListarEventos()

        {
            return bDal.ListarEventos();
        }

        public List<BitacoraActividadTipoEE> ListarTipos()

        {
            return bDal.ListarTipos();
        }

    }
}
