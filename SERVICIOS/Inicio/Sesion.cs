using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EE;

namespace SERVICIOS
{
    public class Sesion
    {
        private EEUsuario _usuario { get; set; }
        public EEUsuario Usuario { get { return _usuario; } }
        public void Login(EEUsuario Usuario) { _usuario = Usuario; }
        public void Logout() { _usuario = null; }
        public bool Estalogueado() { return _usuario != null; }

        bool isInRole(EEPerfilComponente Comp, EEPerfilTipoPermiso Permiso, bool existe)
        {
            if (Comp.Permiso.Equals(Permiso))
                existe = true;
            else
            {
                foreach (var item in Comp.Hijos)
                {
                    existe = isInRole(item, Permiso, existe);
                    if (existe) return true;
                }
            }
            return existe;
        }

        public bool IsInRole(EEPerfilTipoPermiso Permiso)
        {
            bool existe = false;
            foreach (var item in _usuario.Permisos)
            {
                if (item.Permiso.Equals(Permiso))
                    return true;
                else
                {
                    existe = isInRole(item, Permiso, existe);
                    if (existe) return true;
                }
            }
            return existe;
        }

        static IList<InterfazIdiomaObserver> Listaobservadores = new List<InterfazIdiomaObserver>();
        public void SuscribirObs(InterfazIdiomaObserver Obs) { Listaobservadores.Add(Obs); }

        public void DesuscribirObs(InterfazIdiomaObserver Obs) { Listaobservadores.Remove(Obs); }

        public void CambiarIdioma(EEIdioma Idioma)

        {
            if (_usuario != null) { _usuario.Idioma = Idioma; Notificar(Idioma); }
        }
        private static void Notificar(EEIdioma Idioma)

        {
            foreach (var Obs in Listaobservadores) { Obs.UpdateLanguage(Idioma); }
        }
    }
}
