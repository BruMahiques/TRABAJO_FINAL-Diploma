using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EE;
using MPP;

namespace BLL
{
    public class BLLPerfilFamila
    {
        public IList<EEPerfilFamilia> ObtenerFamilias() // Traigo todas las Familias de Base de Datos    
        {
            MPPPerfilFamilia dFamilia = new MPPPerfilFamilia();
            return dFamilia.ObtenerFamilias();
        }



        public void GuardarFamilia(EEPerfilFamilia Fam)

        {
            MPPPerfilFamilia dFamilia = new MPPPerfilFamilia();
            dFamilia.GuardarFamilia(Fam);

        }
    }
}
