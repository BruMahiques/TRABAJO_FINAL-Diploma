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

        public DataTable CargarGrafico(int num, string desde, string hasta)
        {
            Acceso Datos = new Acceso();
            DataTable ds = new DataTable();

            string query;

            switch (num)
            {
                case 1:
                    query = "Select p.Nombre_Producto, Count(v.Id_Producto)[Cantidad vendida del producto] from Venta_Detalle v " +
                        "join Productos p on v.Id_Producto = p.Cod_Producto join Venta vent on v.Id_Venta = vent.Id_Venta where vent.Estado ='Entregado' or Estado = 'Pagado' group by p.Nombre_Producto";
                    break;
                case 2:
                    query = "Select p.Nombre_Producto, sum(v.Sub_total) - sum(p.Precio_Compra)[Total] from Venta_Detalle v " +
                                        "join Productos p on v.Id_Producto = p.Cod_Producto join Venta ven on v.Id_Venta = ven.Id_Venta "+
                                        " where ven.Estado ='Entregado' or Estado = 'Pagado' group by p.Nombre_Producto";
                    break;
                case 3:
                    query = "Select p.Nombre_Producto, Count(v.Id_Producto)[Cantidad vendida del producto] from Venta_Detalle v join Productos p on v.Id_Producto = p.Cod_Producto  " +
                        "join Venta vent on v.Id_Venta = vent.Id_Venta where vent.Estado ='Entregado' or Estado = 'Pagado' and vent.Fecha  BETWEEN ('" + desde + "') and ('" + hasta + "') group by p.Nombre_Producto  ";
                    break;
                case 4:
                    query = "Select p.Nombre_Producto, sum(v.Sub_total) - sum(p.Precio_Compra)[Total] from Venta_Detalle v join Productos p on v.Id_Producto = p.Cod_Producto  " +
                        "join Venta vent on v.Id_Venta = vent.Id_Venta where vent.Estado ='Entregado' or Estado = 'Pagado' and vent.Fecha  BETWEEN ('" + desde + "') and ('" + hasta + "') "+
                        " group by p.Nombre_Producto ";
                    break;


                default:
                    query = "Select p.Nombre_Producto, Count(v.Id_Producto)[Cantidad vendida del producto] from Venta_Detalle v " +
                        "join Productos p on v.Id_Producto = p.Cod_Producto join Venta vent on v.Id_Venta = vent.Id_Venta where vent.Estado ='Entregado' or Estado = 'Pagado' group by p.Nombre_Producto";
                    break;
            }

            ds = Datos.EjecutarCualquierQuerys(query);

            return ds;



        }
    }
}
