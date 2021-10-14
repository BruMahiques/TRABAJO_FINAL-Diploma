using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EE;
using MPP;

namespace BLL
{
    public class BLLPerfilPatente
    {
        public IList<EEPerfilPatente> ObtenerPatentes() // Traigo todas las patentes de Base de Datos    
        {
            MPPPerfilPatente dPatente = new MPPPerfilPatente();
            return dPatente.ObtenerPatentes();
        }

        public Array ObtenerPatentesAtomicas() // Traigo las Patentes Atómicas
        {
            return Enum.GetValues(typeof(EEPerfilTipoPermiso));
        }
    }
}
