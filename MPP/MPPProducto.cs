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
    public class MPPProducto
    {
        public DataSet Listar()
        {
            Acceso Datos = new Acceso();
            return Datos.Leer("SP_Producto_Listar", null);
        }
        public List<EEProducto> ListarProductos()
        {
            Acceso Datos = new Acceso();
            DataSet ds = new DataSet();

            List<EEProducto> LProductos = new List<EEProducto>();

            ds = Datos.Leer("SP_Producto_Listar", null);

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in ds.Tables[0].Rows)
                {
                    EEProducto EEProducto = new EEProducto();
                    EEProducto.Cod_Producto = Convert.ToInt16(fila["Cod_Producto"]);
                    EEProducto.Tipo_Poducto = fila["Tipo_Producto"].ToString();
                    EEProducto.Nombre_Producto = fila["Nombre_Producto"].ToString();
                     EEProducto.Genero =fila["Genero"].ToString();
                    EEProducto.Edad_Producto = fila["Edad_Producto"].ToString();
                    EEProducto.Nacionalidad_Producto = fila["Nacionalidad_Producto"].ToString();
                    EEProducto.Empresa = fila["Empresa"].ToString();

                    LProductos.Add(EEProducto);

                }
            }

            return LProductos;

        }
        public DataSet ListarAlquilados()
        {

            Acceso Datos = new Acceso();
            return Datos.Leer("SP_Producto_Listar_Alquilados", null);

        }
    }
}
