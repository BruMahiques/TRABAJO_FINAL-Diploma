using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EE;
using MPP;

namespace BLL
{
    public class BLLIdiomaTitulo
    {
        public List<EEIdiomaTitulo> ObtenerEtiquetas()
        {
            MPPTraductor MPPTrad = new MPPTraductor();
            return MPPTrad.ObtenerEtiquetas();
        }


        public void abmEtiqueta(EEIdiomaTitulo Etiqueta, int Operacion)

        {
            MPPTraductor dalTrad = new MPPTraductor();
            dalTrad.abmEtiqueta(Etiqueta, Operacion);
        }
    }
}
