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
        
        public DataTable ListarVentasFiltrado(string textbox, string desde, string hasta, int num)
        {
            Acceso Datos = new Acceso();
            DataTable ds = new DataTable();

            string query;

            switch (num)
            {
                case 1:
                    query = "Select  v.Id_Venta as ID,v.Cod_Comprobante, p.Descripcion as Pago ,c.Descripcion as Comprobante, d.Descripcion as Doc, cli.DNI as Numero, v.Fecha, v.Estado, v.Id_Cliente_Venta as [Cliente ID], cli.Nombre , v.Total_Venta as Total " +
                        "From Venta v join Tipo_De_Pago p on v.Id_TipoDePago = p.Id_TipoDePago join Tipo_De_Comprobante c on v.Id_TipoDeComprobante = c.Id_TipoDeComprobante join Tipo_De_Doc d on v.Id_TipoDeDoc = d.Id_TipoDeDoc " +
                        "join Cliente cli on v.Id_Cliente_Venta = cli.Cod_Cliente where v.Id_Venta like('" + textbox + "') and v.Fecha BETWEEN ('" + desde + "') and ('" + hasta + "') ";
                    break;
                case 2:
                    query = "Select  v.Id_Venta as ID,v.Cod_Comprobante, p.Descripcion as Pago ,c.Descripcion as Comprobante, d.Descripcion as Doc, cli.DNI as Numero, v.Fecha, v.Estado, v.Id_Cliente_Venta as [Cliente ID], cli.Nombre , v.Total_Venta as Total " +
                        "From Venta v join Tipo_De_Pago p on v.Id_TipoDePago = p.Id_TipoDePago join Tipo_De_Comprobante c on v.Id_TipoDeComprobante = c.Id_TipoDeComprobante join Tipo_De_Doc d on v.Id_TipoDeDoc = d.Id_TipoDeDoc " +
                        "join Cliente cli on v.Id_Cliente_Venta = cli.Cod_Cliente where v.Cod_Comprobante like('" + textbox + "%') and v.Fecha BETWEEN ('" + desde + "') and ('" + hasta + "') ";
                    break;
                case 3:
                    query = "Select  v.Id_Venta as ID,v.Cod_Comprobante, p.Descripcion as Pago ,c.Descripcion as Comprobante, d.Descripcion as Doc, cli.DNI as Numero, v.Fecha, v.Estado, v.Id_Cliente_Venta as [Cliente ID], cli.Nombre , v.Total_Venta as Total " +
                        "From Venta v join Tipo_De_Pago p on v.Id_TipoDePago = p.Id_TipoDePago join Tipo_De_Comprobante c on v.Id_TipoDeComprobante = c.Id_TipoDeComprobante join Tipo_De_Doc d on v.Id_TipoDeDoc = d.Id_TipoDeDoc " +
                        "join Cliente cli on v.Id_Cliente_Venta = cli.Cod_Cliente where cli.DNI like('" + textbox + "%') and v.Fecha BETWEEN ('" + desde + "') and ('" + hasta + "') ";
                    break;
                case 4:
                    query = "Select  v.Id_Venta as ID,v.Cod_Comprobante, p.Descripcion as Pago ,c.Descripcion as Comprobante, d.Descripcion as Doc, cli.DNI as Numero, v.Fecha, v.Estado, v.Id_Cliente_Venta as [Cliente ID], cli.Nombre , v.Total_Venta as Total " +
                        "From Venta v join Tipo_De_Pago p on v.Id_TipoDePago = p.Id_TipoDePago join Tipo_De_Comprobante c on v.Id_TipoDeComprobante = c.Id_TipoDeComprobante join Tipo_De_Doc d on v.Id_TipoDeDoc = d.Id_TipoDeDoc " +
                        "join Cliente cli on v.Id_Cliente_Venta = cli.Cod_Cliente where cli.Nombre like('" + textbox + "%') and v.Fecha BETWEEN ('" + desde + "') and ('" + hasta + "') ";
                    break;
                case 5:
                    query = "Select  v.Id_Venta as ID,v.Cod_Comprobante, p.Descripcion as Pago ,c.Descripcion as Comprobante, d.Descripcion as Doc, cli.DNI as Numero, v.Fecha, v.Estado, v.Id_Cliente_Venta as [Cliente ID], cli.Nombre , v.Total_Venta as Total " +
                        "From Venta v join Tipo_De_Pago p on v.Id_TipoDePago = p.Id_TipoDePago join Tipo_De_Comprobante c on v.Id_TipoDeComprobante = c.Id_TipoDeComprobante join Tipo_De_Doc d on v.Id_TipoDeDoc = d.Id_TipoDeDoc " +
                        "join Cliente cli on v.Id_Cliente_Venta = cli.Cod_Cliente where v.Estado like('" + textbox + "%') and v.Fecha BETWEEN ('" + desde + "') and ('" + hasta + "') ";
                    break;
                default:
                    query = "Select  v.Id_Venta as ID,v.Cod_Comprobante, p.Descripcion as Pago ,c.Descripcion as Comprobante, d.Descripcion as Doc, cli.DNI as Numero, v.Fecha, v.Estado, v.Id_Cliente_Venta as [Cliente ID], cli.Nombre , v.Total_Venta as Total " +
                        "From Venta v join Tipo_De_Pago p on v.Id_TipoDePago = p.Id_TipoDePago join Tipo_De_Comprobante c on v.Id_TipoDeComprobante = c.Id_TipoDeComprobante join Tipo_De_Doc d on v.Id_TipoDeDoc = d.Id_TipoDeDoc " +
                        "join Cliente cli on v.Id_Cliente_Venta = cli.Cod_Cliente";
                    break;
            }

            

            ds = Datos.EjecutarCualquierQuerys(query);

            return ds;
        }


            
        public DataTable ListarVentaDet(string codigo)
        {
            Acceso Datos = new Acceso();
            DataTable ds = new DataTable();

            string query;

            query = "Select  p.Cod_Producto as Codigo, p.Nombre_Producto as Producto, v.Precio_Prod_Det as Precio_Unitario, v.Cantidad_Det as Cantidad, v.Total_Det as Total " +
                    "From Venta_Detalle v join Productos p on v.Id_Producto_Det = p.Cod_Producto where v.Id_Venta_Det = " + codigo;



            ds = Datos.EjecutarCualquierQuerys(query);

            return ds;



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
        public bool Mod_Estado(EEVenta EEVenta)
        {
            Acceso Datos = new Acceso();
            Hashtable Hdatos = new Hashtable();
            bool Resultado;
            string consulta = "SP_Venta_Cambiar_Estado";


            Hdatos.Add("@Id_Venta", EEVenta.Id_Venta);
            Hdatos.Add("@Estado", EEVenta.Estado);


            Resultado = Datos.Escribir(consulta, Hdatos);
            return Resultado;
        }
        public bool Alta_Venta_Det(EEVentaDet EEVentaDet)
        {
            Acceso Datos = new Acceso();
            Hashtable Hdatos = new Hashtable();
            bool Resultado;
            string consulta = "SP_VentaDet_Alta";


            
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
