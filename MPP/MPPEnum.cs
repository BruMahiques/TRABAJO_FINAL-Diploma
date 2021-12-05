using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EE;
using Datos;
using System.Data;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace MPP
{
    public class MPPEnum
    {
        public List<EEEnum> ObtenerEnum(int constante)

        {
            List<EEEnum> ListaEnum = new List<EEEnum>();

            Acceso Datos = new Acceso();
            DataSet ds = new DataSet();

            switch(constante)
            {
                case 1:
                    ds = Datos.Leer("sp_ListarTipoPago", null);
                    break;
                case 2:
                    ds = Datos.Leer("sp_ListarComprobante", null);
                    break;
                default:
                    ds = Datos.Leer("sp_ListarDocumento", null);
                    break;
            }
           
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow Item in ds.Tables[0].Rows)
                {
                    EEEnum Comprobante = new EEEnum();
                    Comprobante.Cod_Enum = Convert.ToInt32(Item[0]);
                    Comprobante.Descripcion = Item[1].ToString().Trim();


                    ListaEnum.Add(Comprobante);
                }

                return ListaEnum;
            }
            else
            {
                return null;
            }

        }
    }
}
