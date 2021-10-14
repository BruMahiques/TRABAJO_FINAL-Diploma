using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using EE;
using Datos;
using System.Collections;

namespace MPP
{
    public class MPPUsuario
    {
        public List<EEUsuario> ListarUsuarios()

        {
            List<EEUsuario> ListaUsuarios = new List<EEUsuario>();

            Acceso AccesoDB = new Acceso();
            DataSet DS = new DataSet();
            DS = AccesoDB.Leer("sp_ListaUsuarios", null);

            if (DS.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow Item in DS.Tables[0].Rows)
                {
                    EEUsuario oUsuario = new EEUsuario();
                    oUsuario.Id = Convert.ToInt32(Item[0]);
                    oUsuario.Nombre = Item[1].ToString().Trim();
                    oUsuario.Apellido = Item[2].ToString().Trim();
                    oUsuario.Mail = Item[3].ToString().Trim();
                    EEIdioma uIdioma = new EEIdioma();
                    oUsuario.Idioma = uIdioma;
                    oUsuario.Idioma.Cod_Idioma = Convert.ToInt32(Item[4]);
                    oUsuario.Idioma.Idioma = Convert.ToString(Item[5]);
                    oUsuario.dvh = Convert.ToInt32(Item[6]);
                    oUsuario.Clave = Convert.ToString(Item[7]).Trim();

                    ListaUsuarios.Add(oUsuario);
                }

                return ListaUsuarios;
            }
            else
            {
                return null;
            }
        }

        public EE.EEUsuario LeerUsuario(string Mail)  // Para Login, selecciona por mail

        {
            Acceso AccesoDB = new Acceso();
            Hashtable Param = new Hashtable();
            DataSet Ds = new DataSet();
            EEUsuario oUsuario = new EEUsuario();
            Param.Add("@Email", Mail);

            Ds = AccesoDB.Leer("sp_UsuarioLogin", Param);

            if (Ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow Item in Ds.Tables[0].Rows)
                {

                    oUsuario.Id = Convert.ToInt32(Item["Cod_Usuario"]);
                    oUsuario.Nombre = Item["Nombre"].ToString().Trim();
                    oUsuario.Apellido = Item["Apellido"].ToString().Trim();
                    oUsuario.Mail = Item["Email"].ToString().Trim();
                    oUsuario.Clave = Item["Clave"].ToString().Trim();

                    EEIdioma Idioma = new EEIdioma();
                    Idioma.Cod_Idioma = Convert.ToInt32(Item["Cod_Idioma"]);
                    Idioma.Idioma = Item["NombreIdioma"].ToString().Trim();

                    oUsuario.Idioma = Idioma;

                }

            }
            return oUsuario;
        }

        public EE.EEUsuario SeleccionarUsuarioPorId(int Id)

        {
            Acceso AccesoDB = new Acceso();
            Hashtable Param = new Hashtable();
            DataSet Ds = new DataSet();
            EEUsuario oUsuario = new EEUsuario();
            Param.Add("@Id", Id);

            Ds = AccesoDB.Leer("sp_SeleccionarUsuarioPorId", Param);

            if (Ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow Item in Ds.Tables[0].Rows)
                {

                    oUsuario.Id = Convert.ToInt32(Item["Cod_Usuario"]);
                    oUsuario.Nombre = Item["Nombre"].ToString().Trim();
                    oUsuario.Apellido = Item["Apellido"].ToString().Trim();
                    oUsuario.Mail = Item["Email"].ToString().Trim();


                }

            }
            return oUsuario;
        }

        public string Alta(EEUsuario Usuario)

        {
            string Consulta = "sp_InsertarUsuario";
            Hashtable Parametros = new Hashtable();
            

            Parametros.Add("@Nombre", Usuario.Nombre);
            Parametros.Add("@Apellido", Usuario.Apellido);
            Parametros.Add("@Email", Usuario.Mail);
            Parametros.Add("@Clave", Usuario.Clave);
            Parametros.Add("@Cod_Idioma", Usuario.Idioma.Cod_Idioma);
            Parametros.Add("@DVH", Usuario.dvh);

            Acceso nAcceso = new Acceso();

            return nAcceso.EscribirUsu(Consulta, Parametros);
        }


        public void Editar(EEUsuario Usuario)

        {
            string Consulta = "sp_EditarUsuario";
            Hashtable Parametros = new Hashtable();

            Parametros.Add("@Cod_Usuario", Usuario.Id);
            Parametros.Add("@Nombre", Usuario.Nombre);
            Parametros.Add("@Apellido", Usuario.Apellido);
            Parametros.Add("@Email", Usuario.Mail);
            Parametros.Add("@Clave", Usuario.Clave);
            Parametros.Add("@Cod_Idioma", Usuario.Idioma.Cod_Idioma);
            Parametros.Add("@DVH", Usuario.dvh);

            Acceso nAcceso = new Acceso();

            nAcceso.Escribir(Consulta, Parametros);
        }

        public void Eliminar(EEUsuario Usuario)

        {
            string Consulta = "sp_EliminarUsuario";
            Hashtable Parametros = new Hashtable();
            Parametros.Add("@Cod_Usuarios", Usuario.Id);

            Acceso nAcceso = new Acceso();

            nAcceso.Escribir(Consulta, Parametros);
        }


        public void GuardarPermisos(EEUsuario Usuario)

        {
            Acceso nAcceso = new Acceso();
            string ConsultaDel = "sp_BorrarPermisosUsuario"; // Primero borro los permisos que tenía el usuario
            Hashtable ParametrosDel = new Hashtable();
            ParametrosDel.Add("Cod_Usuario", Usuario.Id);
            nAcceso.Escribir(ConsultaDel, ParametrosDel);

            string ConsultaAdd = "sp_GuardarPermisosUsuario"; // Luego guardo los nuevos permisos
            Hashtable ParametrosAdd = new Hashtable();
            ParametrosAdd.Add("Cod_Usuario", Usuario.Id);

            foreach (var item in Usuario.Permisos)
            {

                ParametrosAdd.Add("Cod_Permiso", item.Id);
                nAcceso.Escribir(ConsultaAdd, ParametrosAdd);
                ParametrosAdd.Remove("Cod_Permiso");

            }
        }
        
    }
}
