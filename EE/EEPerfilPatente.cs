using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EE
{
    public class EEPerfilPatente : EEPerfilComponente
    {
        public override IList<EEPerfilComponente> Hijos
        {
            get
            {
                return new List<EEPerfilComponente>();
            }

        }
        public override void AgregarHijo(EEPerfilComponente Comp) { }

        public override void QuitarHijo(EEPerfilComponente Comp) { }

        public override void VaciarHijos() { }
    }
}
