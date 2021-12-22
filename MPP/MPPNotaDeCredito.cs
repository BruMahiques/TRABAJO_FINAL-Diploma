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
    public class MPPNotaDeCredito
    {
        public bool Alta_Nota_Credito(EENotaDeCredito EENotaDeCredito)
        {
            Acceso Datos = new Acceso();
            Hashtable Hdatos = new Hashtable();
            bool Resultado;
            string consulta = "SP_NotaCredito_Alta";


            Hdatos.Add("@Id_Venta", EENotaDeCredito.Venta.Id_Venta);
            Hdatos.Add("@Cod_Comprobante", EENotaDeCredito.Cod_Comprobante);
            Hdatos.Add("@Fecha", EENotaDeCredito.Fecha);
            Hdatos.Add("@Estado", EENotaDeCredito.Estado);
            Hdatos.Add("@Id_Cliente", EENotaDeCredito.Cliente.Cod_Cliente);
            Hdatos.Add("@Total", EENotaDeCredito.Total);

            Resultado = Datos.Escribir(consulta, Hdatos);
            return Resultado;
        }
        public List<EENotaDeCredito> ListarNotaCredito()
        {
            Acceso Datos = new Acceso();
            DataSet ds = new DataSet();

            List<EENotaDeCredito> LNotaDeCredito = new List<EENotaDeCredito>();
            var NotaCredito = new EENotaDeCredito();

            ds = Datos.Leer("SP_Listar_Nota_Credito", null);

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in ds.Tables[0].Rows)
                {
                    NotaCredito = MapearNotaCredito(fila);
                    LNotaDeCredito.Add(NotaCredito);
                }
            }

            return LNotaDeCredito;

        }

        public EENotaDeCredito BuscarID(int id)
        {
            Acceso Datos = new Acceso();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            EENotaDeCredito NotaCredito = null;

            dt = Datos.EjecutarCualquierQuerys("Select * From Nota_De_Credito Where Id_NotaDeCredito=" + id);

            ds.Tables.Add(dt);

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in ds.Tables[0].Rows)
                {
                    NotaCredito = MapearNotaCredito(fila);

                }

            }



            return NotaCredito;

        }

        private EENotaDeCredito MapearNotaCredito(DataRow fila)
        {

            var MPPCliente = new MPPCliente();
            var MPPNotaDeCreditoDet = new MPPNotaDeCreditoDet();
            var MPPVenta = new MPPVenta();


            var NotaCredito = new EENotaDeCredito
            {
                Id_NotaDeCredito = Convert.ToInt32(fila["Id_NotaDeCredito"]),
                Venta = MPPVenta.BuscarID(Convert.ToInt32(fila["Id_Venta"])),
                Cod_Comprobante = fila["Cod_Comprobante"].ToString(),

                LDetalle = MPPNotaDeCreditoDet.ListarNotaDeCreditoDet(Convert.ToInt32(fila["Id_NotaDeCredito"])),

                Fecha = Convert.ToDateTime(fila["Fecha"]),
                Estado = fila["Estado"].ToString(),
                Cliente = MPPCliente.BuscarID(Convert.ToInt32(fila["Id_Cliente"])),
                Total = Convert.ToSingle(fila["Total"])

            };

            return NotaCredito;
        }
    }
}
