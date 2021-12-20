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
        public List<EEReservaDet> ListarVentaDet(int id)
        {
            Acceso Datos = new Acceso();
            DataSet ds = new DataSet();

            List<EEReservaDet> LReservaDet = new List<EEReservaDet>();
            var ReservaDet = new EEReservaDet();

            ds = Datos.Leer("Select * From Reservas_Detalle Where Id_Reserva=" + id, null);

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

                Reserva = MPPReserva.BuscarID(Convert.ToInt32(fila["Id_Reserva"])),
                Producto = MPPProducto.BuscarID(Convert.ToInt32(fila["Cod_Producto"])),
                Cantidad = Convert.ToInt32(fila["Cantidad"]),
                Sub_total = Convert.ToSingle(fila["Sub_total"])

            };

            return ReservaDet;
        }
    }
}
