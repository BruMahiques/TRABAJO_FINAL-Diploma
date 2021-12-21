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
        
            

        public bool Alta_Venta(EEVenta EEVenta)
        {
            Acceso Datos = new Acceso();
            Hashtable Hdatos = new Hashtable();
            bool Resultado;
            string consulta = "SP_Venta_Alta";

            
            //Hdatos.Add("@Id_Venta", EEVenta.Id_Venta);
            Hdatos.Add("@Cod_Comprobante", EEVenta.Cod_Comprobante);
            Hdatos.Add("@Id_TipoDePago", EEVenta.TipoDePago.Id);
            Hdatos.Add("@Fecha", EEVenta.Fecha);
            Hdatos.Add("@Estado", EEVenta.Estado);
            Hdatos.Add("@Id_Cliente_Venta", EEVenta.Cliente.Cod_Cliente);
            Hdatos.Add("@Total_Venta", EEVenta.Total_Venta);

            Resultado = Datos.Escribir(consulta, Hdatos);
            return Resultado;
        }
        /*public bool Mod_Estado(EEVenta EEVenta)
        {
            Acceso Datos = new Acceso();
            Hashtable Hdatos = new Hashtable();
            bool Resultado;
            string consulta = "SP_Venta_Cambiar_Estado";


            Hdatos.Add("@Id_Venta", EEVenta.Id_Venta);
            Hdatos.Add("@Estado", EEVenta.Estado);


            Resultado = Datos.Escribir(consulta, Hdatos);
            return Resultado;
        }*/
        /*

        public bool Stock_Producto(EEVentaDet EEVentaDet)
        {
            Acceso Datos = new Acceso();
            Hashtable Hdatos = new Hashtable();
            bool Resultado;
            string consulta = "SP_Producto_Quitar_Stock";

            
            Hdatos.Add("@Cod_Producto", EEVentaDet.Producto.Cod_Producto);
            Hdatos.Add("@Stock", EEVentaDet.Producto.Stock);

            
            Resultado = Datos.Escribir(consulta, Hdatos);
            return Resultado;
        }
        */
        /*
        public DataTable CargarGrafico(int num, string desde, string hasta)
        {
            Acceso Datos = new Acceso();
            DataTable ds = new DataTable();

            string query;
            
            switch (num)
            {
                case 1:
                    query = "Select p.Nombre_Producto, Count(v.Id_Producto)[Cantidad vendida del producto] from Venta_Detalle v " +
                        "join Productos p on v.Id_Producto = p.Cod_Producto group by p.Nombre_Producto";
                    break;
                case 2:
                    query = "Select p.Nombre_Producto, sum(v.Total_Det) - sum(p.Precio_Compra)[Total] from Venta_Detalle v " +
                                        "join Productos p on v.Id_Producto = p.Cod_Producto group by p.Nombre_Producto";
                    break;
                case 3:
                    query = "Select p.Nombre_Producto, Count(v.Id_Producto)[Cantidad vendida del producto] from Venta_Detalle v join Productos p on v.Id_Producto = p.Cod_Producto  " +
                        "join Venta vent on v.Id_Venta = vent.Id_Venta where vent.Fecha  BETWEEN ('" + desde + "') and ('" + hasta + "') group by p.Nombre_Producto  ";
                    break;
                case 4:
                    query = "Select p.Nombre_Producto, sum(v.Total_Det) - sum(p.Precio_Compra)[Total] from Venta_Detalle v join Productos p on v.Id_Producto = p.Cod_Producto  " +
                        "join Venta vent on v.Id_Venta = vent.Id_Venta where vent.Fecha  BETWEEN ('" + desde + "') and ('" + hasta + "') group by p.Nombre_Producto " ;
                    break;
                
                    
                default:
                    query = "Select p.Nombre_Producto, Count(v.Id_Producto)[Cantidad vendida del producto] from Venta_Detalle v " +
                        "join Productos p on v.Id_Producto = p.Cod_Producto group by p.Nombre_Producto";
                    break;
            }

            ds = Datos.EjecutarCualquierQuerys(query);

            return ds;



        }
        */
        public List<EEVenta> ListarVentasFiltrado(string textbox, string desde, string hasta, int num)
        {
            Acceso Datos = new Acceso();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            List<EEVenta> LVenta = new List<EEVenta>();
            var Venta = new EEVenta();
            string query;

            switch (num)
            {
                case 1:
                    query = "Select  * " +
                        "From Venta v join Tipo_De_Pago p on v.Id_TipoDePago = p.Id_TipoDePago join Tipo_De_Comprobante c on v.Id_TipoDeComprobante = c.Id_TipoDeComprobante join Tipo_De_Doc d on v.Id_TipoDeDoc = d.Id_TipoDeDoc " +
                        "join Cliente cli on v.Id_Cliente_Venta = cli.Cod_Cliente where v.Id_Venta like('" + textbox + "') and v.Fecha BETWEEN ('" + desde + "') and ('" + hasta + "') ";
                    break;
                case 2:
                    query = "Select * " +
                        "From Venta v join Tipo_De_Pago p on v.Id_TipoDePago = p.Id_TipoDePago join Tipo_De_Comprobante c on v.Id_TipoDeComprobante = c.Id_TipoDeComprobante join Tipo_De_Doc d on v.Id_TipoDeDoc = d.Id_TipoDeDoc " +
                        "join Cliente cli on v.Id_Cliente_Venta = cli.Cod_Cliente where v.Cod_Comprobante like('" + textbox + "%') and v.Fecha BETWEEN ('" + desde + "') and ('" + hasta + "') ";
                    break;
                case 3:
                    query = "Select  * " +
                        "From Venta v join Tipo_De_Pago p on v.Id_TipoDePago = p.Id_TipoDePago join Tipo_De_Comprobante c on v.Id_TipoDeComprobante = c.Id_TipoDeComprobante join Tipo_De_Doc d on v.Id_TipoDeDoc = d.Id_TipoDeDoc " +
                        "join Cliente cli on v.Id_Cliente_Venta = cli.Cod_Cliente where cli.DNI like('" + textbox + "%') and v.Fecha BETWEEN ('" + desde + "') and ('" + hasta + "') ";
                    break;
                case 4:
                    query = "Select  * " +
                        "From Venta v join Tipo_De_Pago p on v.Id_TipoDePago = p.Id_TipoDePago join Tipo_De_Comprobante c on v.Id_TipoDeComprobante = c.Id_TipoDeComprobante join Tipo_De_Doc d on v.Id_TipoDeDoc = d.Id_TipoDeDoc " +
                        "join Cliente cli on v.Id_Cliente_Venta = cli.Cod_Cliente where cli.Nombre like('" + textbox + "%') and v.Fecha BETWEEN ('" + desde + "') and ('" + hasta + "') ";
                    break;
                case 5:
                    query = "Select  * " +
                        "From Venta v join Tipo_De_Pago p on v.Id_TipoDePago = p.Id_TipoDePago join Tipo_De_Comprobante c on v.Id_TipoDeComprobante = c.Id_TipoDeComprobante join Tipo_De_Doc d on v.Id_TipoDeDoc = d.Id_TipoDeDoc " +
                        "join Cliente cli on v.Id_Cliente_Venta = cli.Cod_Cliente where v.Estado like('" + textbox + "%') and v.Fecha BETWEEN ('" + desde + "') and ('" + hasta + "') ";
                    break;
                default:
                    query = "Select  * " +
                        "From Venta v join Tipo_De_Pago p on v.Id_TipoDePago = p.Id_TipoDePago join Tipo_De_Comprobante c on v.Id_TipoDeComprobante = c.Id_TipoDeComprobante join Tipo_De_Doc d on v.Id_TipoDeDoc = d.Id_TipoDeDoc " +
                        "join Cliente cli on v.Id_Cliente_Venta = cli.Cod_Cliente";
                    break;
            }

            dt = Datos.EjecutarCualquierQuerys(query);

            ds.Tables.Add(dt);

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in ds.Tables[0].Rows)
                {
                    Venta = MapearVenta(fila);
                    LVenta.Add(Venta);
                }
            }

            return LVenta;

        }
        public List<EEVenta> ListarVenta()
        {
            Acceso Datos = new Acceso();
            DataSet ds = new DataSet();

            List<EEVenta> LVenta = new List<EEVenta>();
            var Venta = new EEVenta();

            ds = Datos.Leer("SP_Listar_Ventas", null);

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in ds.Tables[0].Rows)
                {
                    Venta = MapearVenta(fila);
                    LVenta.Add(Venta);
                }
            }

            return LVenta;

        }

        public EEVenta BuscarID(int id)
        {
            Acceso Datos = new Acceso();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            EEVenta venta = null;

            dt = Datos.EjecutarCualquierQuerys("Select * From Venta Where Id_Venta=" + id);

            ds.Tables.Add(dt);

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in ds.Tables[0].Rows)
                {
                    venta = MapearVenta(fila);

                }

            }



            return venta;

        }

        private EEVenta MapearVenta(DataRow fila)
        {

            var MPPCliente = new MPPCliente();
            var MPPTipoDePago = new MPPTipoDePago();
            var LDetalle  =  new List<EEVentaDet>();
            var MPPVentaDet = new MPPVentaDet();


            var Venta = new EEVenta
            {

                Id_Venta = Convert.ToInt32(fila["Id_Venta"]),
                Cod_Comprobante = fila["Cod_Comprobante"].ToString(),
                TipoDePago = MPPTipoDePago.BuscarID(Convert.ToInt32(fila["Id_TipoDePago"])),
                
                LDetalle = MPPVentaDet.ListarVentaDet(Convert.ToInt32(fila["Id_Venta"])),
                
                Fecha = Convert.ToDateTime(fila["Fecha"]),
                Estado = fila["Estado"].ToString(),
                Cliente = MPPCliente.BuscarID(Convert.ToInt32(fila["Id_Cliente_Venta"])),
                Total_Venta = Convert.ToSingle(fila["Total_Venta"])

            };

            return Venta;
        }

    }
}
