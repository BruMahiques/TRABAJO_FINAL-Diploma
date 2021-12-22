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
    public class MPPNotaDeCreditoDet
    {
        public bool Alta_NotaCredito_Det(EENotaDeCreditoDet EENotaDeCreditoDet)
        {
            Acceso Datos = new Acceso();
            Hashtable Hdatos = new Hashtable();
            bool Resultado;
            string consulta = "SP_NotaCreditoDet_Alta";



            Hdatos.Add("@Id_Producto", EENotaDeCreditoDet.Producto.Cod_Producto);
            Hdatos.Add("@Id_NotaDeCredito", EENotaDeCreditoDet.Id_NotaDeCredito);
            Hdatos.Add("@Cantidad_Nota", EENotaDeCreditoDet.Cantidad);
            Hdatos.Add("@Sub_Total", EENotaDeCreditoDet.Sub_total);


            Resultado = Datos.Escribir(consulta, Hdatos);
            return Resultado;
        }
        public List<EENotaDeCreditoDet> ListarNotaDeCreditoDet(int id)
        {
            Acceso Datos = new Acceso();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();


            List<EENotaDeCreditoDet> LNotaCredDet = new List<EENotaDeCreditoDet>();
            var NotaCreditoDet = new EENotaDeCreditoDet();

            dt = Datos.EjecutarCualquierQuerys("Select * From Nota_De_Credito_Detalle Where Id_NotaDeCredito=" + id);

            ds.Tables.Add(dt);

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in ds.Tables[0].Rows)
                {
                    NotaCreditoDet = MapearNotaCreditoDet(fila);
                    LNotaCredDet.Add(NotaCreditoDet);
                }
            }

            return LNotaCredDet;

        }

        private EENotaDeCreditoDet MapearNotaCreditoDet(DataRow fila)
        {

            MPPProducto MPPProducto = new MPPProducto();
            




            var NotaCredDet = new EENotaDeCreditoDet
            {

                Id_NotaDeCredito = Convert.ToInt32(fila["Id_NotaDeCredito"]),
                Producto = MPPProducto.BuscarID(Convert.ToInt32(fila["Id_Producto"])),
                Cantidad = Convert.ToInt32(fila["Cantidad_Nota"]),
                Sub_total = Convert.ToSingle(fila["Sub_Total"])

            };

            return NotaCredDet;
        }
    }
}
