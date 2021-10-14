using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EE;
using Datos;
using System.Collections;
using System.Data;

namespace SERVICIOS.Bitacora
{
    public class BitacoraDAL
    {
        public void NuevaActividad(BitacoraActividadEE nAct)

        {
            Hashtable Parametros = new Hashtable();

            Parametros.Add("@Usuario", nAct.Usuario.Id);
            Parametros.Add("@Fecha", nAct.Fecha);
            Parametros.Add("@Tipo", nAct.Tipo.Id);
            Parametros.Add("@Detalle", nAct.Detalle);

            Acceso AccesoDB = new Acceso();
            AccesoDB.Escribir("sp_InsertarActividadBitacora", Parametros);
        }


        public List<BitacoraActividadEE> ListarEventos()

        {
            List<BitacoraActividadEE> ListaEventos = new List<BitacoraActividadEE>();

            Acceso AccesoDB = new Acceso();
            DataSet DS = new DataSet();
            DS = AccesoDB.Leer("sp_ListaBitacoraEventos", null);

            if (DS.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow Item in DS.Tables[0].Rows)
                {

                    BitacoraActividadEE oEvento = new BitacoraActividadEE();
                    oEvento.Id = Convert.ToInt32(Item[0]);
                    oEvento.Usuario.Id = Convert.ToInt32(Item[1]);
                    oEvento.Usuario.Nombre = Convert.ToString(Item[2]).Trim();
                    oEvento.Usuario.Apellido = Convert.ToString(Item[3]).Trim();
                    oEvento.Fecha = Convert.ToDateTime(Item[4]);
                    BitacoraActividadTipoEE Tipo = new BitacoraActividadTipoEE();
                    Tipo.Id = Convert.ToInt32(Item[5]);
                    Tipo.Tipo = Convert.ToString(Item[6]).Trim();
                    oEvento.SetTipo(Tipo);
                    oEvento.Detalle = Convert.ToString(Item[7]).Trim();

                    ListaEventos.Add(oEvento);

                }

            }
            return ListaEventos;
        }

        public List<BitacoraActividadTipoEE> ListarTipos()

        {
            List<BitacoraActividadTipoEE> ListaTipos = new List<BitacoraActividadTipoEE>();

            Acceso AccesoDB = new Acceso();
            DataSet DS = new DataSet();
            DS = AccesoDB.Leer("sp_ListarBitacoraTipo", null);

            if (DS.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow Item in DS.Tables[0].Rows)
                {
                    BitacoraActividadTipoEE oTipo = new BitacoraActividadTipoEE();

                    oTipo.Id = Convert.ToInt32(Item[0]);
                    oTipo.Tipo = Convert.ToString(Item[1]).Trim();
                    ListaTipos.Add(oTipo);

                }

            }
            return ListaTipos;

        }
    }
}
