using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace EE
{
    public class EEUsuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

         public string Clave { get; set; }

        public EEIdioma Idioma { get; set; }

        public int dvh { get; set; }

        public string Mail { get; set; }

        List<EEPerfilComponente> permisos;
        public EEUsuario() { permisos = new List<EEPerfilComponente>(); }

        
        public List<EEPerfilComponente> Permisos { get { return permisos; } }
        public bool ExistePermisoExplisito(EEPerfilComponente Perm) { if (permisos.Exists(permisos => permisos.Id == Perm.Id)) return true; else return false; } // Verifico que el permiso esté de forma directa en el Usuario, para poder eliminarlo luego
        public void AgregarPermiso(EEPerfilComponente Perm) { permisos.Add(Perm); }
        public void QuitarPermiso(EEPerfilComponente Perm) { permisos.Remove(permisos.Where(permisos => permisos.Id == Perm.Id).First()); }
        public override string ToString()
        {
            return Nombre + " " + Apellido;
        }

    }
}
