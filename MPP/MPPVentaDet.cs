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
    public class MPPVentaDet
    {
        public bool Alta_Venta_Det(EEVentaDet EEVentaDet)
        {
            Acceso Datos = new Acceso();
            Hashtable Hdatos = new Hashtable();
            bool Resultado;
            string consulta = "SP_VentaDet_Alta";



            Hdatos.Add("@Id_Producto_Det", EEVentaDet.Producto.Cod_Producto);
            Hdatos.Add("@Id_Venta_Det", EEVentaDet.Id_Venta);
            Hdatos.Add("@Cantidad_Det", EEVentaDet.Cantidad);
            Hdatos.Add("@Sub_Total", EEVentaDet.Sub_total);


            Resultado = Datos.Escribir(consulta, Hdatos);
            return Resultado;
        }
        public List<EEVentaDet> ListarVentaDet(int id)
        {
            Acceso Datos = new Acceso();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();


            List<EEVentaDet> LVentaDet = new List<EEVentaDet>();
            var VentaDet = new EEVentaDet();

            dt = Datos.EjecutarCualquierQuerys("Select * From Venta_Detalle Where Id_Venta="+id);

            ds.Tables.Add(dt);

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in ds.Tables[0].Rows)
                {
                    VentaDet = MapearVentaDet(fila);
                    LVentaDet.Add(VentaDet);
                }
            }

            return LVentaDet;

        }
                
        private EEVentaDet MapearVentaDet(DataRow fila)
        {

            MPPProducto MPPProducto = new MPPProducto();
            MPPVenta MPPVenta = new MPPVenta();




            var VentaDet = new EEVentaDet
            {

                Id_Venta = Convert.ToInt32(fila["Id_Venta"]),
                Producto = MPPProducto.BuscarID(Convert.ToInt32(fila["Id_Producto"])),
                Cantidad = Convert.ToInt32(fila["Cantidad_Det"]),
                Sub_total = Convert.ToSingle(fila["Sub_total"])

            };

            return VentaDet;
        }
    }
}
