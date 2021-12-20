﻿using System;
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
        public List<EEVentaDet> ListarVentaDet(int id)
        {
            Acceso Datos = new Acceso();
            DataSet ds = new DataSet();

            List<EEVentaDet> LVentaDet = new List<EEVentaDet>();
            var VentaDet = new EEVentaDet();

            ds = Datos.Leer("Select * From Venta_Detalle Where Id_Venta="+id, null);

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

                Venta = MPPVenta.BuscarID(Convert.ToInt32(fila["Id_Venta"])),
                Producto = MPPProducto.BuscarID(Convert.ToInt32(fila["Cod_Producto"])),
                Cantidad = Convert.ToInt32(fila["Cantidad"]),
                Sub_total = Convert.ToSingle(fila["Sub_total"])

            };

            return VentaDet;
        }
    }
}
