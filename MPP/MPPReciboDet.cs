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
    public class MPPReciboDet
    {
        public bool Alta_Recibo_Det(EEReciboDet EEReciboDet)
        {
            Acceso Datos = new Acceso();
            Hashtable Hdatos = new Hashtable();
            bool Resultado;
            string consulta = "SP_ReciboDet_Alta";



            Hdatos.Add("@Id_Producto", EEReciboDet.Producto.Cod_Producto);
            Hdatos.Add("@Id_Recibo", EEReciboDet.Id_Recibo);
            Hdatos.Add("@Cantidad_Recibo", EEReciboDet.Cantidad);
            Hdatos.Add("@Sub_Total", EEReciboDet.Sub_total);


            Resultado = Datos.Escribir(consulta, Hdatos);
            return Resultado;
        }
        public List<EEReciboDet> ListarReciboDet(int id)
        {
            Acceso Datos = new Acceso();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();


            List<EEReciboDet> LReciboDet = new List<EEReciboDet>();
            var ReciboDet = new EEReciboDet();

            dt = Datos.EjecutarCualquierQuerys("Select * From Recibo_Detalle Where Id_Recibo=" + id);

            ds.Tables.Add(dt);

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in ds.Tables[0].Rows)
                {
                    ReciboDet = MapearReciboDet(fila);
                    LReciboDet.Add(ReciboDet);
                }
            }

            return LReciboDet;

        }

        private EEReciboDet MapearReciboDet(DataRow fila)
        {

            MPPProducto MPPProducto = new MPPProducto();
           




            var ReciboDet = new EEReciboDet
            {

                Id_Recibo = Convert.ToInt32(fila["Id_Recibo"]),
                Producto = MPPProducto.BuscarID(Convert.ToInt32(fila["Id_Producto"])),
                Cantidad = Convert.ToInt32(fila["Cantidad_Recibo"]),
                Sub_total = Convert.ToSingle(fila["Sub_Total"])

            };

            return ReciboDet;
        }
    }
}
