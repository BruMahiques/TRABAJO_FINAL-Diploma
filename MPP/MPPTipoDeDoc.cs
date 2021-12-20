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
    public class MPPTipoDeDoc
    {
        public EETipoDeDoc BuscarID(int id)
        {
            Acceso Datos = new Acceso();
            DataSet ds = new DataSet();

            EETipoDeDoc TipoDeDoc = null;

            ds = Datos.Leer("Select * From Tipo_De_Doc Where Id_TipoDeDoc=" + id, null);

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in ds.Tables[0].Rows)
                {
                    TipoDeDoc = MapearTipoDeDoc(fila);

                }

            }



            return TipoDeDoc;

        }

        private EETipoDeDoc MapearTipoDeDoc(DataRow fila)
        {


            var TipoDeDeDoc = new EETipoDeDoc
            {

                Id = Convert.ToInt32(fila["Id_TipoDeDeDoc"]),
                Descripcion = fila["Descripcion"].ToString()



            };

            return TipoDeDeDoc;
        }
    }
}
