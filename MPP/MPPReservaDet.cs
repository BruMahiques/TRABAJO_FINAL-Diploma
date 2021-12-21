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
    public class MPPReservaDet
    {
        
        public bool Alta_Reserva_Det(EEReservaDet ReservaDet)
        {
            Acceso Datos = new Acceso();
            Hashtable Hdatos = new Hashtable();
            bool Resultado;
            string consulta = "SP_ReservaDet_Alta";



            Hdatos.Add("@Id_Producto_Det", ReservaDet.Producto.Cod_Producto);
            Hdatos.Add("@Id_Reserva_Det", ReservaDet.Id_Reserva);
            Hdatos.Add("@Cantidad_Det", ReservaDet.Cantidad);
            Hdatos.Add("@Sub_Total", ReservaDet.Sub_total);


            Resultado = Datos.Escribir(consulta, Hdatos);
            return Resultado;
        }
        public List<EEReservaDet> ListarVentaDet(int id)
        {
            Acceso Datos = new Acceso();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            List<EEReservaDet> LReservaDet = new List<EEReservaDet>();
            var ReservaDet = new EEReservaDet();

            dt = Datos.EjecutarCualquierQuerys("Select * From Reservas_Detalle Where Id_Reserva=" + id);

            ds.Tables.Add(dt);

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in ds.Tables[0].Rows)
                {
                    ReservaDet = MapearReservaDet(fila);
                    LReservaDet.Add(ReservaDet);
                }
            }

            return LReservaDet;

        }

        private EEReservaDet MapearReservaDet(DataRow fila)
        {

            MPPProducto MPPProducto = new MPPProducto();
            MPPReserva MPPReserva = new MPPReserva();




            var ReservaDet = new EEReservaDet
            {

                Id_Reserva = Convert.ToInt32(fila["Id_Reserva"]),
                Producto = MPPProducto.BuscarID(Convert.ToInt32(fila["Id_Producto"])),
                Cantidad = Convert.ToInt32(fila["Cantidad_Det"]),
                Sub_total = Convert.ToSingle(fila["Sub_total"])

            };

            return ReservaDet;
        }
    }
}
