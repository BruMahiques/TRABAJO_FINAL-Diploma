using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;
using System.Collections;
using EE;

namespace MPP
{
    public class MPPPerfilComponente
    {
        public void GuardarComponente(EEPerfilComponente Comp, bool EsFamilia)

        {
            Acceso nAcceso = new Acceso();

            string Consulta = "sp_InsertarComponente";
            Hashtable Parametros = new Hashtable();

            Parametros.Add("Descripcion", Comp.Descripcion);

            if (EsFamilia) Parametros.Add("Permiso", DBNull.Value);

            else Parametros.Add("Permiso", Comp.Permiso.ToString()); ;

            nAcceso.EscribirUsu(Consulta, Parametros);

        }

        public IList<EEPerfilComponente> ObtenerTodo(EEPerfilFamilia Familia)
        {
            Acceso nAcceso = new Acceso();
            Hashtable Parametros = new Hashtable();
            Parametros.Add("Fam", Familia.Id);
            DataSet DS = new DataSet();
            DS = nAcceso.Leer("sp_ObtenerTodoFamilia", Parametros);

            var Lista = new List<EEPerfilComponente>();

            if (DS.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow Item in DS.Tables[0].Rows)
                {

                    int id_padre = 0;
                    if (Item["Cod_Padre"] != DBNull.Value)
                    {
                        id_padre = Convert.ToInt32(Item["Cod_Padre"]);
                    }

                    var id = Convert.ToInt32(Item["Cod_Permiso"]);
                    var nombre = Convert.ToString(Item["Descripcion"]);

                    var permiso = string.Empty;
                    if (Item["Permiso"] != DBNull.Value)
                        permiso = Convert.ToString(Item["Permiso"]);


                    EEPerfilComponente c;

                    if (string.IsNullOrEmpty(permiso))
                        c = new EEPerfilFamilia();

                    else
                        c = new EEPerfilPatente();

                    c.Id = id;
                    c.Descripcion = nombre;
                    if (!string.IsNullOrEmpty(permiso))
                        c.Permiso = (EEPerfilTipoPermiso)Enum.Parse(typeof(EEPerfilTipoPermiso), permiso);

                    var padre = ObtenerComponente(id_padre, Lista);

                    if (padre == null)
                    {
                        Lista.Add(c);
                    }
                    else
                    {
                        padre.AgregarHijo(c);
                    }

                }
            }

            return Lista;
        }

        public void CompletarComponentesFamilia(EEPerfilFamilia familia)
        {
            familia.VaciarHijos();
            foreach (var item in ObtenerTodo(familia))
            {
                familia.AgregarHijo(item);
            }
        }

        private EE.EEPerfilComponente ObtenerComponente(int id, IList<EEPerfilComponente> lista)
        {

            EEPerfilComponente Componente = lista != null ? lista.Where(i => i.Id.Equals(id)).FirstOrDefault() : null;

            if (Componente == null && lista != null)
            {
                foreach (var c in lista)
                {

                    var l = ObtenerComponente(id, c.Hijos);
                    if (l != null && l.Id == id) return l;
                    else
                    if (l != null)
                        return ObtenerComponente(id, l.Hijos);
                }
            }

            return Componente;
        }

        public void CargarPerfilUsuario(EEUsuario Us)

        {
            Acceso nAcceso = new Acceso();
            Hashtable Parametros = new Hashtable();
            Parametros.Add("Cod_Usuario", Us.Id);
            DataSet DS = new DataSet();
            DS = nAcceso.Leer("sp_ListaPermisosUsuario", Parametros);

            Us.Permisos.Clear();
            if (DS.Tables[0].Rows.Count > 0)
            {

                foreach (DataRow Item in DS.Tables[0].Rows)
                {
                    var IdPermiso = Convert.ToInt32(Item["Cod_Permiso"]);
                    var DescPermiso = Convert.ToString(Item["Descripcion"]);
                    var Permiso = string.Empty;

                    if (Item["Permiso"] != DBNull.Value) { Permiso = Convert.ToString(Item["Permiso"]); }



                    if (!String.IsNullOrEmpty(Permiso))

                    {
                        EEPerfilPatente Patente = new EEPerfilPatente();
                        Patente.Id = IdPermiso;
                        Patente.Descripcion = DescPermiso;
                        Patente.Permiso = (EEPerfilTipoPermiso)Enum.Parse(typeof(EEPerfilTipoPermiso), Permiso);
                        Us.Permisos.Add(Patente);
                    }

                    else

                    {
                        EEPerfilFamilia Familia = new EEPerfilFamilia();
                        Familia.Permiso = (EEPerfilTipoPermiso)Enum.Parse(typeof(EEPerfilTipoPermiso), "Ninguno"); // Se hace esto porque al instanciar la familia asigna un permiso enum automáticamente
                        Familia.Id = IdPermiso;                        
                        Familia.Descripcion = DescPermiso;

                        var Arbol = ObtenerTodo(Familia);

                        foreach (var hijo in Arbol)

                        {
                            Familia.AgregarHijo(hijo);
                        }

                        Us.Permisos.Add(Familia);
                    }
                }
            }

        }
    }
}
