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
    public class MPPRecibo
    {
        public bool Alta_Recibo(EERecibo EERecibo)
        {
            Acceso Datos = new Acceso();
            Hashtable Hdatos = new Hashtable();
            bool Resultado;
            string consulta = "SP_Recibo_Alta";


            Hdatos.Add("@Id_Venta", EERecibo.Venta.Id_Venta);
            Hdatos.Add("@Cod_Comprobante", EERecibo.Cod_Comprobante);
            Hdatos.Add("@Fecha", EERecibo.Fecha);
            Hdatos.Add("@Estado", EERecibo.Estado);
            Hdatos.Add("@Id_Cliente_Recibo", EERecibo.Cliente.Cod_Cliente);
            Hdatos.Add("@Total_Recibo", EERecibo.Total);

            Resultado = Datos.Escribir(consulta, Hdatos);
            return Resultado;
        }
        public List<EERecibo> ListarRecibo()
        {
            Acceso Datos = new Acceso();
            DataSet ds = new DataSet();

            List<EERecibo> LRecibo = new List<EERecibo>();
            var Recibo = new EERecibo();

            ds = Datos.Leer("SP_Listar_Recibos", null);

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in ds.Tables[0].Rows)
                {
                    Recibo = MapearRecibo(fila);
                    LRecibo.Add(Recibo);
                }
            }

            return LRecibo;

        }
        public List<EERecibo> ListarRecibosDeVenta(int id)
        {
            Acceso Datos = new Acceso();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            List<EERecibo> LRecibo = new List<EERecibo>();
            

            EERecibo recibo = null;

            dt = Datos.EjecutarCualquierQuerys("Select * From Recibo Where Id_Venta=" + id);

            ds.Tables.Add(dt);

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in ds.Tables[0].Rows)
                {
                    recibo = MapearRecibo(fila);
                    LRecibo.Add(recibo);

                }

            }
            
            return LRecibo;

        }

        public void CambiarEstadoVenta(int id)
        {
           Acceso Datos = new Acceso();
           
           Datos.EjecutarCualquierQuerys("update Venta  set  Estado = '"+ "Entregado" +"' where Id_Venta = " + id);
                

        }

        public EERecibo BuscarID(int id)
        {
            Acceso Datos = new Acceso();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            EERecibo recibo = null;

            dt = Datos.EjecutarCualquierQuerys("Select * From Recibo Where Id_Recibo=" + id);

            ds.Tables.Add(dt);

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in ds.Tables[0].Rows)
                {
                    recibo = MapearRecibo(fila);

                }

            }



            return recibo;

        }

        private EERecibo MapearRecibo(DataRow fila)
        {

            var MPPCliente = new MPPCliente();
            var MPPReciboDet = new MPPReciboDet();
            var MPPVenta = new MPPVenta();


            var Recibo = new EERecibo
            {

                Id_Recibo = Convert.ToInt32(fila["Id_Recibo"]),
                Venta = MPPVenta.BuscarID(Convert.ToInt32(fila["Id_Venta"])),
                Cod_Comprobante = fila["Cod_Comprobante"].ToString(),
                
                LDetalle = MPPReciboDet.ListarReciboDet(Convert.ToInt32(fila["Id_Recibo"])),

                Fecha = Convert.ToDateTime(fila["Fecha"]),
                Estado = fila["Estado"].ToString(),
                Cliente = MPPCliente.BuscarID(Convert.ToInt32(fila["Id_Cliente_Recibo"])),
                Total = Convert.ToSingle(fila["Total_Recibo"])

            };

            return Recibo;
        }
    }
}
