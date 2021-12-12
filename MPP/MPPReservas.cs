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
    public class MPPReservas
    {
        Acceso data = new Acceso();

        public bool Alta_Reserva(EEReservas Reserva)
        {
            Acceso Datos = new Acceso();
            Hashtable Hdatos = new Hashtable();
            bool Resultado;
            string consulta = "SP_Reserva_Alta";


           
            Hdatos.Add("@Cod_Comprobante", Reserva.Cod_Comprobante);
            Hdatos.Add("@Id_TipoDePago", Reserva.Id_TipoDePago);
            Hdatos.Add("@Id_TipoDeDoc", Reserva.Id_TipoDeDoc);
            Hdatos.Add("@Fecha", Reserva.Fecha);
            Hdatos.Add("@Estado", Reserva.Estado);
            Hdatos.Add("@Id_Cliente_Reserva", Reserva.Id_Cliente_Reserva);
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



            Hdatos.Add("@Id_Producto_Det", EEVentaDet.Id_Producto_Det);
            Hdatos.Add("@Id_Reserva_Det", EEVentaDet.Id_Venta_Det);
            Hdatos.Add("@Precio_Prod_Det", EEVentaDet.Precio_Prod_Det);
            Hdatos.Add("@Cantidad_Det", EEVentaDet.Cantidad_Det);
            Hdatos.Add("@Total_Det", EEVentaDet.Total_Det);


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
    }
}
