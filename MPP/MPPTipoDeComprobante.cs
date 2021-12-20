using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using EE;
using System.Collections;
using System.Data;

namespace MPP
{
    public class MPPTipoDeComprobante
    {
        public EETipoDeComprobante BuscarID(int id)
        {
            Acceso Datos = new Acceso();
            DataSet ds = new DataSet();

            EETipoDeComprobante TipoDeComprobante = null;

            ds = Datos.Leer("Select * From Tipo_De_Comprobante Where Id_TipoDeComprobante=" + id, null);

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in ds.Tables[0].Rows)
                {
                    TipoDeComprobante = MapearTipoDeComprobante(fila);

                }

            }



            return TipoDeComprobante;

        }

        private EETipoDeComprobante MapearTipoDeComprobante(DataRow fila)
        {


            var TipoDeComprobante = new EETipoDeComprobante
            {

                Id = Convert.ToInt32(fila["Id_TipoDeComprobante"]),
                Descripcion = fila["Descripcion"].ToString()



            };

            return TipoDeComprobante;
        }
    }
}
