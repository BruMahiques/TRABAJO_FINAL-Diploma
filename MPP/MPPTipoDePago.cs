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
    public class MPPTipoDePago
    {
        public List<EETipoDePago> ListarTipoDePago()
        {
            Acceso Datos = new Acceso();
            DataSet ds = new DataSet();

            List<EETipoDePago> LTipoDePago = new List<EETipoDePago>();
            var EETipoDePago = new EETipoDePago();

            ds = Datos.Leer("Select * From Tipo_De_Pago", null);

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in ds.Tables[0].Rows)
                {
                    EETipoDePago = MapearTipoDePago(fila);
                    LTipoDePago.Add(EETipoDePago);

                }
            }

            return LTipoDePago;

        }
        public EETipoDePago BuscarID(int id)
        {
            Acceso Datos = new Acceso();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            EETipoDePago Tipodepago = null;

            dt = Datos.EjecutarCualquierQuerys("Select * From Tipo_De_Pago Where Id_TipoDePago=" + id);

            ds.Tables.Add(dt);

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in ds.Tables[0].Rows)
                {
                    Tipodepago = MapearTipoDePago(fila);

                }

            }



            return Tipodepago;

        }

        private EETipoDePago MapearTipoDePago(DataRow fila)
        {


            var Tipodepago = new EETipoDePago
            {

                Id = Convert.ToInt32(fila["Id_TipoDePago"]),
                Descripcion = fila["Descripcion"].ToString()
               


            };

            return Tipodepago;
        }
    }
}
