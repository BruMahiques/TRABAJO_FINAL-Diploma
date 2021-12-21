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
        public List<EETipoDeDoc> ListarTipoDeDoc()
        {
            Acceso Datos = new Acceso();
            DataSet ds = new DataSet();

            List<EETipoDeDoc> LTipoDeDoc = new List<EETipoDeDoc>();
            var EETipoDeDoc = new EETipoDeDoc();

            ds = Datos.Leer("Select * From Tipo_De_Doc", null);

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in ds.Tables[0].Rows)
                {
                    EETipoDeDoc = MapearTipoDeDoc(fila);
                    LTipoDeDoc.Add(EETipoDeDoc);

                }
            }

            return LTipoDeDoc;

        }
        public EETipoDeDoc BuscarID(int id)
        {
            Acceso Datos = new Acceso();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            EETipoDeDoc TipoDeDoc = null;

            dt = Datos.EjecutarCualquierQuerys("Select * From Tipo_De_Doc Where Id_TipoDeDoc=" + id);

            ds.Tables.Add(dt);

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


            var TipoDeDoc = new EETipoDeDoc
            {

                Id = Convert.ToInt32(fila["Id_TipoDeDoc"]),
                Descripcion = fila["Descripcion"].ToString()



            };

            return TipoDeDoc;
        }
    }
}
