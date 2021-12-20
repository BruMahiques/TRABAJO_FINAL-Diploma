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
    public class MPPReserva
    {
        Acceso data = new Acceso();

        public bool Alta_Reserva(EEReserva Reserva)
        {
            Acceso Datos = new Acceso();
            Hashtable Hdatos = new Hashtable();
            bool Resultado;
            string consulta = "SP_Reserva_Alta";


           
            Hdatos.Add("@Cod_Comprobante", Reserva.Cod_Comprobante);
            Hdatos.Add("@Id_TipoDePago", Reserva.TipoDePago.Id);
            Hdatos.Add("@Id_TipoDeDoc", Reserva.TipoDeDoc.Id);
            Hdatos.Add("@Fecha", Reserva.Fecha);
            Hdatos.Add("@Estado", Reserva.Estado);
            Hdatos.Add("@Id_Cliente_Reserva", Reserva.Cliente.Cod_Cliente);
            Hdatos.Add("@Seña", Reserva.Seña);
            Hdatos.Add("@Total", Reserva.Total);

            Resultado = Datos.Escribir(consulta, Hdatos);
            return Resultado;
        }
        
        public bool Alta_Reserva_Det(EEVentaDet EEVentaDet)
        {
            Acceso Datos = new Acceso();
            Hashtable Hdatos = new Hashtable();
            bool Resultado;
            string consulta = "SP_ReservaDet_Alta";



            Hdatos.Add("@Id_Producto_Det", EEVentaDet.Producto.Cod_Producto);
            Hdatos.Add("@Id_Reserva_Det", EEVentaDet.Venta.Id_Venta);
            Hdatos.Add("@Precio_Prod_Det", EEVentaDet.Producto.Precio_Venta);
            Hdatos.Add("@Cantidad_Det", EEVentaDet.Cantidad);
            Hdatos.Add("@Total_Det", EEVentaDet.Sub_total);


            Resultado = Datos.Escribir(consulta, Hdatos);
            return Resultado;
        }
        
            public DataTable ListarReservasFiltrado(string textbox, string desde, string hasta, int num)
        {
            Acceso Datos = new Acceso();
            DataTable ds = new DataTable();

            string query;

            switch (num)
            {
                case 1:
                    query = "Select  r.Id_Reserva as ID,r.Cod_Comprobante, p.Descripcion as Pago , d.Descripcion as Doc, cli.DNI as Numero, r.Fecha, r.Estado, r.Id_Cliente_Reserva as [Cliente ID], cli.Nombre, cli.Correo , r.Seña ,r.Total as Total " +
                        "From Reservas r join Tipo_De_Pago p on r.Id_TipoDePago = p.Id_TipoDePago join Tipo_De_Doc d on r.Id_TipoDeDoc = d.Id_TipoDeDoc " +
                        "join Cliente cli on r.Id_Cliente_Reserva = cli.Cod_Cliente where r.Id_Reserva like('" + textbox + "') and r.Fecha BETWEEN ('" + desde + "') and ('" + hasta + "') ";
                    break;
                case 2:
                    query = "Select  r.Id_Reserva as ID,r.Cod_Comprobante, p.Descripcion as Pago , d.Descripcion as Doc, cli.DNI as Numero, r.Fecha, r.Estado, r.Id_Cliente_Reserva as [Cliente ID], cli.Nombre, cli.Correo , r.Seña ,r.Total as Total " +
                        "From Reservas r join Tipo_De_Pago p on r.Id_TipoDePago = p.Id_TipoDePago join Tipo_De_Doc d on r.Id_TipoDeDoc = d.Id_TipoDeDoc " +
                        "join Cliente cli on r.Id_Cliente_Reserva = cli.Cod_Cliente where r.Cod_Comprobante like('%" + textbox + "%') and r.Fecha BETWEEN ('" + desde + "') and ('" + hasta + "') ";
                    break;
                case 3:
                    query = "Select  r.Id_Reserva as ID,r.Cod_Comprobante, p.Descripcion as Pago , d.Descripcion as Doc, cli.DNI as Numero, r.Fecha, r.Estado, r.Id_Cliente_Reserva as [Cliente ID], cli.Nombre, cli.Correo , r.Seña ,r.Total as Total " +
                        "From Reservas r join Tipo_De_Pago p on r.Id_TipoDePago = p.Id_TipoDePago join Tipo_De_Doc d on r.Id_TipoDeDoc = d.Id_TipoDeDoc " +
                        "join Cliente cli on r.Id_Cliente_Reserva = cli.Cod_Cliente where cli.DNI like('" + textbox + "%') and r.Fecha BETWEEN ('" + desde + "') and ('" + hasta + "') ";
                    break;
                case 4:
                    query = "Select  r.Id_Reserva as ID,r.Cod_Comprobante, p.Descripcion as Pago , d.Descripcion as Doc, cli.DNI as Numero, r.Fecha, r.Estado, r.Id_Cliente_Reserva as [Cliente ID], cli.Nombre, cli.Correo , r.Seña ,r.Total as Total " +
                        "From Reservas r join Tipo_De_Pago p on r.Id_TipoDePago = p.Id_TipoDePago join Tipo_De_Doc d on r.Id_TipoDeDoc = d.Id_TipoDeDoc " +
                        "join Cliente cli on r.Id_Cliente_Reserva = cli.Cod_Cliente where cli.Nombre like('" + textbox + "%') and r.Fecha BETWEEN ('" + desde + "') and ('" + hasta + "') ";
                    break;
                case 5:
                    query = "Select  r.Id_Reserva as ID,r.Cod_Comprobante, p.Descripcion as Pago , d.Descripcion as Doc, cli.DNI as Numero, r.Fecha, r.Estado, r.Id_Cliente_Reserva as [Cliente ID], cli.Nombre, cli.Correo , r.Seña ,r.Total as Total " +
                        "From Reservas r join Tipo_De_Pago p on r.Id_TipoDePago = p.Id_TipoDePago join Tipo_De_Doc d on r.Id_TipoDeDoc = d.Id_TipoDeDoc " +
                        "join Cliente cli on r.Id_Cliente_Reserva = cli.Cod_Cliente where r.Estado like('" + textbox + "%') and r.Fecha BETWEEN ('" + desde + "') and ('" + hasta + "') ";
                    break;
                case 6:
                    query = "Select  r.Id_Reserva as ID,r.Cod_Comprobante, p.Descripcion as Pago , d.Descripcion as Doc, cli.DNI as Numero, r.Fecha, r.Estado, r.Id_Cliente_Reserva as [Cliente ID], cli.Nombre, cli.Correo , r.Seña ,r.Total as Total " +
                        "From Reservas r join Tipo_De_Pago p on r.Id_TipoDePago = p.Id_TipoDePago join Tipo_De_Doc d on r.Id_TipoDeDoc = d.Id_TipoDeDoc " +
                        "join Cliente cli on r.Id_Cliente_Reserva = cli.Cod_Cliente where r.Id_Reserva like('" + textbox + "')";
                    break;
                default:
                    query = "Select  r.Id_Reserva as ID,r.Cod_Comprobante, p.Descripcion as Pago , d.Descripcion as Doc, cli.DNI as Numero, r.Fecha, r.Estado, r.Id_Cliente_Reserva as [Cliente ID], cli.Nombre , cli.Correo ,r.Seña ,r.Total as Total " +
                        "From Reservas r join Tipo_De_Pago p on r.Id_TipoDePago = p.Id_TipoDePago join Tipo_De_Doc d on r.Id_TipoDeDoc = d.Id_TipoDeDoc " +
                        "join Cliente cli on r.Id_Cliente_Reserva = cli.Cod_Cliente";
                    break;
            }



            ds = Datos.EjecutarCualquierQuerys(query);

            return ds;
        }
        public DataTable ListarResDet(string codigo)
        {
            Acceso Datos = new Acceso();
            DataTable ds = new DataTable();

            string query;

            query = "Select  p.Cod_Producto as Codigo, p.Nombre_Producto as Producto, r.Precio_Prod_Det as Precio_Unitario, r.Cantidad_Det as Cantidad, r.Total_Det as Total " +
                    " From Reservas_Detalle r join Productos p on r.Id_Producto_Det = p.Cod_Producto where r.Id_reserva_det = " + codigo;



            ds = Datos.EjecutarCualquierQuerys(query);

            return ds;



        }
        public EEReserva BuscarID(int id)
        {
            Acceso Datos = new Acceso();
            DataSet ds = new DataSet();

            EEReserva reserva = null;

            ds = Datos.Leer("Select * From Reservas Where Id_Reserva=" + id, null);

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in ds.Tables[0].Rows)
                {
                    reserva = MapearReserva(fila);

                }

            }



            return reserva;

        }

        private EEReserva MapearReserva(DataRow fila)
        {

            var MPPCliente = new MPPCliente();
            var MPPTipoDePago = new MPPTipoDePago();
            var MPPTipoDeDoc = new MPPTipoDeDoc();
            
            var LDetalle = new List<EEReservaDet>();
            var MPPReservaDet = new MPPReservaDet();


            var Reserva = new EEReserva
            {

                Id_Reserva = Convert.ToInt32(fila["Id_Reserva"]),
                Cod_Comprobante = fila["Cod_Comprobante"].ToString(),

                TipoDeDoc = MPPTipoDeDoc.BuscarID(Convert.ToInt32(fila["Id_TipoDeDoc"])),
                TipoDePago = MPPTipoDePago.BuscarID(Convert.ToInt32(fila["Id_TipoDePago"])),
                

                LDetalle = MPPReservaDet.ListarVentaDet(Convert.ToInt32(fila["Id_Reserva"])),


                Fecha = Convert.ToDateTime(fila["Fecha"]),
                Estado = fila["Estado"].ToString(),
                Cliente = MPPCliente.BuscarID(Convert.ToInt32(fila["Cod_Cliente"])),
                Total = Convert.ToSingle(fila["Total_Venta"])

            };

            return Reserva;
        }
    }
}
