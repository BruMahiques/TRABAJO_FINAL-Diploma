using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EE
{
    public class EEPerfilFamilia : EEPerfilComponente
    {
        private IList<EEPerfilComponente> _hijos;
        public EEPerfilFamilia()
        {
            _hijos = new List<EEPerfilComponente>();
        }

        public override IList<EEPerfilComponente> Hijos
        {
            get
            {
                return _hijos.ToArray();
            }
        }

        public override void VaciarHijos()
        {
            _hijos = new List<EEPerfilComponente>();
        }
        public override void AgregarHijo(EEPerfilComponente Comp)
        {
            _hijos.Add(Comp);
        }
        public override void QuitarHijo(EEPerfilComponente Comp)

        {
            _hijos.Remove(Hijos.Where(_hijos => _hijos.Id == Comp.Id).First());
        }
    }
}
