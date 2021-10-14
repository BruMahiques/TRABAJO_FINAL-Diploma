using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EE
{
    public abstract class EEPerfilComponente
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public abstract IList<EEPerfilComponente> Hijos { get; }
        public abstract void AgregarHijo(EEPerfilComponente Comp);
        public abstract void QuitarHijo(EEPerfilComponente Comp);
        public abstract void VaciarHijos();
        public EEPerfilTipoPermiso Permiso { get; set; }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
