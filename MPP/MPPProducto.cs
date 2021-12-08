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
        public bool Alta_Mod_Producto(EEProducto EEProducto)
        {
            Acceso Datos = new Acceso();
            Hashtable Hdatos = new Hashtable();
            bool Resultado;
            string consulta = "SP_Producto_Alta";

            if (EEProducto.Cod_Producto != 0)
            {
                consulta = "SP_Producto_Modificar";
                Hdatos.Add("@Cod_Producto", EEProducto.Cod_Producto);

            }
            Hdatos.Add("@Nombre_Producto", EEProducto.Nombre_Producto);
            Hdatos.Add("@Duracion", EEProducto.Duracion);
            Hdatos.Add("@Edad_Producto", EEProducto.Edad_Producto);
            Hdatos.Add("@Precio_Compra", EEProducto.Precio_Compra);
            Hdatos.Add("@Precio_Venta", EEProducto.Precio_Venta);
            Hdatos.Add("@Categoria", EEProducto.Categoria);
            Hdatos.Add("@Stock", EEProducto.Stock);
            Hdatos.Add("@Cant_Jugadores", EEProducto.Cant_Jugadores);

            Resultado = Datos.Escribir(consulta, Hdatos);
            return Resultado;
        }

        public bool BajaProducto(EEProducto EEProducto)
        {
            Acceso Datos = new Acceso();
            Hashtable Hdatos = new Hashtable();
            bool Resultado;
            Hdatos.Add("@Cod_Producto", EEProducto.Cod_Producto);
            string consulta = "SP_Producto_Baja";
            return Resultado = Datos.Escribir(consulta, Hdatos);

        }

        public List<EEProducto> ListarProductos()
        {
            Acceso Datos = new Acceso();
            DataSet ds = new DataSet();

            List<EEProducto> LProducto = new List<EEProducto>();

            ds = Datos.Leer("SP_Producto_Listar", null);

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in ds.Tables[0].Rows)
                {
                    EEProducto EEProducto = new EEProducto();
                    EEProducto.Cod_Producto = Convert.ToInt32(fila["Cod_Producto"]);
                    EEProducto.Nombre_Producto = fila["Nombre_Producto"].ToString();
                    EEProducto.Duracion = fila["Duracion"].ToString();
                    EEProducto.Edad_Producto = fila["Edad_Producto"].ToString();
                    EEProducto.Precio_Compra = Convert.ToDouble(fila["Precio_Compra"]);
                    EEProducto.Precio_Venta = Convert.ToDouble(fila["Precio_Venta"]);
                    EEProducto.Categoria = fila["Categoria"].ToString();
                    EEProducto.Stock = Convert.ToInt32(fila["Stock"]);
                    EEProducto.Cant_Jugadores = fila["Cant_Jugadores"].ToString();

                    LProducto.Add(EEProducto);

                }
            }

            return LProducto;

        }

        public DataTable ListarProductosFiltrado(string textbox, int num)
        {
            Acceso Datos = new Acceso();
            DataTable ds = new DataTable();

            string query;

            switch (num)
            {
                case 1:
                    query = "SELECT * FROM Productos where Nombre_Producto like ('" + textbox + "%')";
                    break;
                case 2:
                    query = "SELECT * FROM Productos where Categoria like ('" + textbox + "%')";
                    break;
                case 3:
                    query = "SELECT * FROM Productos where Precio_Venta like ('" + textbox + "%')";
                    break;
                default:
                    query = "SELECT * FROM Productos where Cant_Jugadores like ('" + textbox + "%')";
                    break;
            }

            

            ds = Datos.EjecutarCualquierQuerys(query);


            return ds;

        }
        public int ExisteProductoEnComprobante(EEProducto EEProducto)
        {

            Acceso Datos = new Acceso();
            DataTable dt = new DataTable();

            string query;


            query = "SELECT COUNT(1) FROM Venta_Detalle WHERE Id_Producto_Det = '" + EEProducto.Cod_Producto + "'; ";

            dt = Datos.EjecutarCualquierQuerys(query);

            int num = Convert.ToInt32(dt.Rows[0][0]);

            return num;

        }
    }
}
