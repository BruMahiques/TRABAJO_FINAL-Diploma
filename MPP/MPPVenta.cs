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
    public class MPPVenta
    {
        public List<EEVenta> ListarVenta()
        {
            Acceso Datos = new Acceso();
            DataSet ds = new DataSet();

            List<EEVenta> LVenta = new List<EEVenta>();

            ds = Datos.Leer("SP_Venta_Listar", null);

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in ds.Tables[0].Rows)
                {
                    EEVenta EEVenta = new EEVenta();
                    EEVenta.Id_Venta = Convert.ToInt32(fila["Id_Venta"]);
                    EEVenta.Cod_Comprobante = fila["Cod_Comprobante"].ToString();
                    EEVenta.Id_TipoDePago = Convert.ToInt32(fila["Id_TipoDePago"]);
                    EEVenta.Id_TipoDeDoc = Convert.ToInt32(fila["Id_TipoDeDoc"]);
                    EEVenta.Id_TipoDeComprobante = Convert.ToInt32(fila["Id_TipoDeComprobante"]);
                    EEVenta.Fecha = Convert.ToDateTime(fila["Fecha"]);
                    EEVenta.Estado = fila["Estado"].ToString();
                    EEVenta.Id_Cliente_Venta = Convert.ToInt32(fila["Id_Cliente_Venta"]);
                    EEVenta.Total_Venta = Convert.ToInt32(fila["Total_Venta"]);

                    LVenta.Add(EEVenta);

                }
            }

            return LVenta;

        }
        public List<EEVentaDet> ListarVentaDet()
        {
            Acceso Datos = new Acceso();
            DataSet ds = new DataSet();

            List<EEVentaDet> LVentaDet = new List<EEVentaDet>();

            ds = Datos.Leer("SP_VentaDet_Listar", null);

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in ds.Tables[0].Rows)
                {
                    EEVentaDet EEVentaDet = new EEVentaDet();
                    EEVentaDet.Id_Det = Convert.ToInt32(fila["Id_Det"]);
                    EEVentaDet.Id_Producto_Det = Convert.ToInt32(fila["Id_Producto_Det"]);
                    EEVentaDet.Id_Venta_Det = Convert.ToInt32(fila["Id_Venta_Det"]);
                    EEVentaDet.Precio_Prod_Det = Convert.ToInt32(fila["Precio_Prod_Det"]);
                    EEVentaDet.Cantidad_Det = Convert.ToInt32(fila["Cantidad_Det"]);
                    EEVentaDet.Total_Det = Convert.ToInt32(fila["Total_Det"]);
         
                    LVentaDet.Add(EEVentaDet);

                }
            }

            return LVentaDet;

        }

        public bool Alta_Venta(EEVenta EEVenta)
        {
            Acceso Datos = new Acceso();
            Hashtable Hdatos = new Hashtable();
            bool Resultado;
            string consulta = "SP_Venta_Alta";

            
            //Hdatos.Add("@Id_Venta", EEVenta.Id_Venta);
            Hdatos.Add("@Cod_Comprobante", EEVenta.Cod_Comprobante);
            Hdatos.Add("@Id_TipoDePago", EEVenta.Id_TipoDePago);
            Hdatos.Add("@Id_TipoDeDoc", EEVenta.Id_TipoDeDoc);
            Hdatos.Add("@Id_TipoDeComprobante", EEVenta.Id_TipoDeComprobante);
            Hdatos.Add("@Fecha", EEVenta.Fecha);
            Hdatos.Add("@Estado", EEVenta.Estado);
            Hdatos.Add("@Id_Cliente_Venta", EEVenta.Id_Cliente_Venta);
            Hdatos.Add("@Total_Venta", EEVenta.Total_Venta);

            Resultado = Datos.Escribir(consulta, Hdatos);
            return Resultado;
        }
        public bool Alta_Venta_Det(EEVentaDet EEVentaDet)
        {
            Acceso Datos = new Acceso();
            Hashtable Hdatos = new Hashtable();
            bool Resultado;
            string consulta = "SP_VentaDet_Alta";


            //Hdatos.Add("@Id_Det", EEVentaDet.Id_Det);
            Hdatos.Add("@Id_Producto_Det", EEVentaDet.Id_Producto_Det);
            Hdatos.Add("@Id_Venta_Det", EEVentaDet.Id_Venta_Det);
            Hdatos.Add("@Precio_Prod_Det", EEVentaDet.Precio_Prod_Det);
            Hdatos.Add("@Cantidad_Det", EEVentaDet.Cantidad_Det);
            Hdatos.Add("@Total_Det", EEVentaDet.Total_Det);
            

            Resultado = Datos.Escribir(consulta, Hdatos);
            return Resultado;
        }

        public bool Stock_Producto(EEVentaDet EEVentaDet)
        {
            Acceso Datos = new Acceso();
            Hashtable Hdatos = new Hashtable();
            bool Resultado;
            string consulta = "SP_Producto_Quitar_Stock";

            
            Hdatos.Add("@Cod_Producto", EEVentaDet.Id_Producto_Det);
            Hdatos.Add("@Stock", EEVentaDet.Cantidad_Det);

            
            Resultado = Datos.Escribir(consulta, Hdatos);
            return Resultado;
        }
    }
}
