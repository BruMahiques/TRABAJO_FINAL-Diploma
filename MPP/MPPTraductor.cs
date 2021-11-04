using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EE;
using Datos;
using System.Data;
using System.Collections;
using System.Security.Cryptography.X509Certificates;


namespace MPP
{
    public class MPPTraductor
    {



        public List<EEIdioma> ObtenerIdiomas()

        {
            List<EEIdioma> ListaIdiomas = new List<EEIdioma>();

            Acceso Datos = new Acceso();
            DataSet ds = new DataSet();
            ds = Datos.Leer("sp_ListarIdiomas", null);

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow Item in ds.Tables[0].Rows)
                {
                    EEIdioma Idioma = new EEIdioma();
                    Idioma.Cod_Idioma = Convert.ToInt32(Item[0]);
                    Idioma.Idioma = Item[1].ToString().Trim();
                    Idioma.Por_Defecto = Convert.ToBoolean(Item[2]);

                    ListaIdiomas.Add(Idioma);
                }

                return ListaIdiomas;
            }
            else
            {
                return null;
            }

        }

        public Dictionary<string, EEIdiomaTraduccion> ObtenerTraducciones(EEIdioma Idioma)

        {
            Dictionary<string, EEIdiomaTraduccion> ListaTraducciones = new Dictionary<string, EEIdiomaTraduccion>();

            Acceso Datos = new Acceso();
            DataSet ds = new DataSet();
            Hashtable Param = new Hashtable();
            Param.Add("@Idioma", Idioma.Cod_Idioma);
            ds = Datos.Leer("sp_ListaTraducciones", Param);

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow Item in ds.Tables[0].Rows)
                {

                    EEIdiomaTraduccion Traduccion = new EEIdiomaTraduccion();
                    EEIdiomaTitulo Etiqueta = new EEIdiomaTitulo();

                    Etiqueta.Cod_Titulo = Convert.ToInt32(Item[0]);
                    Etiqueta.Descripcion = Item[1].ToString().Trim();
                    Traduccion.Titulo = Etiqueta;
                    Traduccion.Texto = Item[2].ToString().Trim();

                    ListaTraducciones.Add(Etiqueta.Descripcion, Traduccion);
                }

                return ListaTraducciones;
            }
            else
            {
                return null;
            }
        }

        public List<EEIdiomaTitulo> ObtenerEtiquetas()

        {
            List<EEIdiomaTitulo> ListaEtiquetas = new List<EEIdiomaTitulo>();

            Acceso Datos = new Acceso();
            DataSet ds = new DataSet();
            ds = Datos.Leer("sp_ListaTitulosIdioma", null);

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow Item in ds.Tables[0].Rows)
                {
                    EEIdiomaTitulo oEtiqueta = new EEIdiomaTitulo();
                    oEtiqueta.Cod_Titulo = Convert.ToInt32(Item[0]);
                    oEtiqueta.Descripcion = Item[1].ToString().Trim();


                    ListaEtiquetas.Add(oEtiqueta);
                }

                return ListaEtiquetas;
            }
            else
            {
                return null;
            }

        }

        public void abmEtiqueta(EEIdiomaTitulo Etiqueta, int Operacion)
        {
            string Consulta;

            switch (Operacion)
            {
                case 1:
                    Consulta = "sp_InsertarTituloIdioma";
                    break;
                case 2:
                    Consulta = "sp_EditarTituloIdioma";
                    break;
                case 3:
                    Consulta = "sp_BorrarTituloIdioma";
                    break;
                default:
                    Consulta = null;
                    break;
            }

            Hashtable Parametros = new Hashtable();

            if (Operacion != 3)
            {
                if (Etiqueta.Cod_Titulo != 0)
                {
                    Parametros.Add("@Cod_Titulo", Etiqueta.Cod_Titulo);
                }

                Parametros.Add("@Descripcion", Etiqueta.Descripcion);

            }
            else
            {
                Parametros.Add("@Cod_Titulo", Etiqueta.Cod_Titulo);
            }
            Acceso nDatos = new Acceso();

            nDatos.EscribirUsu(Consulta, Parametros);

        }

        public void InsertarEditarTraduccion(EEIdioma Idioma, EEIdiomaTraduccion Traduccion, int Operacion)
        {
            string Consulta;
            Hashtable Parametros = new Hashtable();
            Parametros.Add("@Cod_Titulo", Traduccion.Titulo.Cod_Titulo);
            Parametros.Add("@Texto", Traduccion.Texto);
            Parametros.Add("@Cod_Idioma", Idioma.Cod_Idioma);
            switch (Operacion)
            {
                case 1:
                    Consulta = "sp_InsertarTraduccion";
                    break;
                case 2:
                    Consulta = "sp_EditarTraduccion";
                    break;
                default:
                    Consulta = null;
                    break;
            }

            Acceso Datos = new Acceso();
            Datos.EscribirUsu(Consulta, Parametros);

        }

        public void Insetaridioma(EEIdioma Idioma, bool SetDefault)

        {
            Hashtable Parametros = new Hashtable();
            Parametros.Add("@Idioma", Idioma.Idioma);
            Parametros.Add("@Por_Defecto", SetDefault);
            Acceso Datos = new Acceso();
            Datos.EscribirUsu("sp_InsertarIdioma", Parametros);
        }

        public void EditarIdioma(EEIdioma Idioma, bool SetDefault)

        {

            Hashtable Parametros = new Hashtable();
            Parametros.Add("@Cod_Idioma", Idioma.Cod_Idioma);
            Acceso Datos = new Acceso();

            if (SetDefault == true)

            {
                Datos.EscribirUsu("sp_CambiarIdiomaDefecto", Parametros);

                Parametros.Add("@Idioma", Idioma.Idioma);
                Datos.EscribirUsu("sp_EditarIdioma", Parametros);
            }

            else
            {
                Parametros.Add("@Idioma", Idioma.Idioma);
                Datos.EscribirUsu("sp_EditarIdioma", Parametros);

            }
        }

        public void EliminarIdioma(EEIdioma Idioma)
        {
            Hashtable Parametros = new Hashtable();
            Parametros.Add("@Cod_Idioma", Idioma.Cod_Idioma);
            Acceso Datos = new Acceso();
            Datos.EscribirUsu("sp_BorrarIdioma", Parametros);

        }

    }
}
