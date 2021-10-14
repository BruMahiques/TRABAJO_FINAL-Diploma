using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EE;
using MPP;

namespace BLL
{
    public class BLLPerfilComponente
    {
        public void GuardarComponente(EEPerfilComponente Comp, bool EsFamilia)

        {
            MPPPerfilComponente nComp = new MPPPerfilComponente();
            nComp.GuardarComponente(Comp, EsFamilia);
        }

        public IList<EEPerfilComponente> ObtenerTodo(EEPerfilFamilia Fam)

        {
            MPPPerfilComponente nComp = new MPPPerfilComponente();
            return nComp.ObtenerTodo(Fam);
        }

        public void CompletarComponentesFamilia(EEPerfilFamilia Familia)

        {
            MPPPerfilComponente nComp = new MPPPerfilComponente();
            nComp.CompletarComponentesFamilia(Familia);
        }

        public void CargarPerfilUsuario(EEUsuario Us)

        {
            MPPPerfilComponente nComp = new MPPPerfilComponente();
            nComp.CargarPerfilUsuario(Us);
        }

        public bool Existe(EEPerfilComponente Comp, int id)
        {
            bool existe = false;

            if (Comp.Id.Equals(id))
                existe = true;
            else

                foreach (var item in Comp.Hijos)
                {

                    existe = Existe(item, id);
                    if (existe) return true;
                }

            return existe;

        }
    }
}
