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
        public EEVentaDet BuscarID(int id)
        {
            Acceso Datos = new Acceso();
            DataSet ds = new DataSet();

            EEVentaDet ventadet = null;

            ds = Datos.Leer("Select * From Venta_Detalle Where Id_Venta=" + id, null);

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in ds.Tables[0].Rows)
                {
                    ventadet = MapearVentaDet(fila);

                }

            }



            return ventadet;

        }

        private EEVentaDet MapearVentaDet(DataRow fila)
        {

            MPPCliente MPPCliente = new MPPCliente();
            MPPTipoDePago MPPTipoDePago = new MPPTipoDePago();
            MPPTipoDeDoc MPPTipoDeDoc = new MPPTipoDeDoc();
            MPPTipoDeComprobante MPPTipoDeComprobante = new MPPTipoDeComprobante();


            var VentaDet = new EEVentaDet
            {

                /*Id_Venta = Convert.ToInt32(fila["Id_Venta"]),
                Cod_Comprobante = fila["Cod_Comprobante"].ToString(),
                TipoDePago = MPPTipoDePago.BuscarID(Convert.ToInt32(fila["Id_TipoDePago"]),
                TipoDeDoc = MPPTipoDeDoc.BuscarID(Convert.ToInt32(fila["Id_TipoDeDoc"]),
                TipoDeComprobante = MPPTipoDeComprobante.BuscarID(Convert.ToInt32(fila["Id_TipoDeComprobante"]),
                Fecha = Convert.ToDouble(fila["Precio_Venta"]),
                Estado = fila["Categoria"].ToString(),
                Cliente = MPPCliente.BuscarID(Convert.ToInt32(fila["Cod_Cliente"]),
                Total_Venta = fila["Cant_Jugadores"].ToString() */

            };

            return VentaDet;
        }
    }
}
