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
    public class MPPTarjeta
    {
        public EETarjetas BuscarNumero(int numero,int codigo)
        {
            Acceso Datos = new Acceso();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            EETarjetas tarjeta = null;


            dt = Datos.EjecutarCualquierQuerys("Select * From Tarjetas Where Numero= " + numero + " and Codigo = " + codigo);

            ds.Tables.Add(dt);

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in ds.Tables[0].Rows)
                {
                    tarjeta = MapearTarjeta(fila);

                }

            }



            return tarjeta;

        }
        private EETarjetas MapearTarjeta(DataRow fila)
        {

            var MPPCliente = new MPPCliente();
            

            var Tarjeta = new EETarjetas
            {

                
                Cliente = MPPCliente.BuscarID(Convert.ToInt32(fila["Id_Cliente"])),
                Numero = Convert.ToInt32(fila["Numero"]),
                Codigo = Convert.ToInt32(fila["Codigo"]),                
                Saldo = Convert.ToSingle(fila["Saldo"])

            };

            return Tarjeta;
        }
    }
}
