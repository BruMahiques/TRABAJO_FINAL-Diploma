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

        public bool Alta_Reserva(EEReservas EEReservas)
        {
            Acceso Datos = new Acceso();
            Hashtable Hdatos = new Hashtable();
            bool Resultado;
            string consulta = "SP_Alquiler_Alta";
                       
            Hdatos.Add("@Cod_Cliente", EEReservas.Cod_Cliente);
            Hdatos.Add("@Cod_Producto", EEReservas.Cod_Producto);
            Hdatos.Add("@Dias", EEReservas.Dias);
            Hdatos.Add("@Importe", EEReservas.Importe);
            
            


            Resultado = Datos.Escribir(consulta, Hdatos);
            return Resultado;
        }

        public bool BajaReserva(EEReservas EEReservas)
        {
            Acceso Datos = new Acceso();
            Hashtable Hdatos = new Hashtable();
            bool Resultado;
            Hdatos.Add("@Cod_Producto", EEReservas.Cod_Producto);
            Hdatos.Add("@Cod_Cliente", EEReservas.Cod_Cliente);


            return Resultado = Datos.Escribir("SP_Alquiler_Baja", Hdatos);

        }

        public List<EEReservas> ListarReserva()
        {
            Acceso Datos = new Acceso();
            DataSet ds = new DataSet();

            List<EEReservas> LReserva = new List<EEReservas>();

            ds = Datos.Leer("SP_Alquiler_Listar", null);

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in ds.Tables[0].Rows)
                {
                    EEReservas EEReservas = new EEReservas();
                    EEReservas.Cod_Cliente = Convert.ToInt16(fila["Cod_Cliente"]);
                    EEReservas.Cod_Producto = Convert.ToInt16(fila["Cod_Producto"]);
                    EEReservas.Dias = Convert.ToInt32(fila["Dias"]);
                    EEReservas.Importe = Convert.ToDouble(fila["Importe"]);
                    LReserva.Add(EEReservas);

                }
            }

            return LReserva;
        }
    }
}
