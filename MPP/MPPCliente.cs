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
    public class MPPCliente
    {
        public bool Alta_Mod_Cliente(EECliente EECliente)
        {
            Acceso Datos = new Acceso();
            Hashtable Hdatos = new Hashtable();
            bool Resultado;
            string consulta = "SP_Cliente_Alta";

            if (EECliente.Cod_Cliente != 0)
            {
                consulta = "SP_Cliente_Modificar";
                Hdatos.Add("@Cod_Cliente", EECliente.Cod_Cliente);

            }
            Hdatos.Add("@Nombre", EECliente.Nombre);
            Hdatos.Add("@Apellido", EECliente.Apellido);
            Hdatos.Add("@DNI", EECliente.DNI);
            Hdatos.Add("@FechaNac", EECliente.FechaNac);
            Hdatos.Add("@Correo", EECliente.Correo);

            Resultado = Datos.Escribir(consulta, Hdatos);
            return Resultado;
        }

        public bool BajaCliente(EECliente EECliente)
        {
            Acceso Datos = new Acceso();
            Hashtable Hdatos = new Hashtable();
            bool Resultado;
            Hdatos.Add("@Cod_Cliente", EECliente.Cod_Cliente);
            string consulta = "SP_Cliente_Baja";
            return Resultado = Datos.Escribir(consulta, Hdatos);

        }

        public List<EECliente> ListarCliente()
        {
            Acceso Datos = new Acceso();
            DataSet ds = new DataSet();

            List<EECliente> LClientes = new List<EECliente>();

            ds = Datos.Leer("SP_Cliente_Listar", null);

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in ds.Tables[0].Rows)
                {
                    EECliente EECliente = new EECliente();
                    EECliente.Cod_Cliente = Convert.ToInt16(fila["Cod_Cliente"]);
                    EECliente.Nombre = fila["Nombre"].ToString();
                    EECliente.Apellido = fila["Apellido"].ToString();
                    EECliente.DNI = Convert.ToInt32(fila["DNI"]);
                    EECliente.FechaNac = Convert.ToDateTime(fila["FechaNac"]);
                    EECliente.Correo = fila["Correo"].ToString();
                    LClientes.Add(EECliente);

                }
            }

            return LClientes;

        }

        public DataTable ListarClientesFiltrado(string textbox, string textbox2, int num)
        {
            Acceso Datos = new Acceso();
            DataTable ds = new DataTable();

            string query;

            switch (num)
            {
                case 1:
                    query = "SELECT * FROM Cliente where DNI like ('" + textbox + "%') and Nombre like ('" + textbox2 + "%')";
                    break;
                case 2:
                    query = "SELECT * FROM Cliente where Nombre like ('" + textbox2 + "%')";
                    break;

                default:
                    query = "SELECT * FROM Cliente where DNI like ('" + textbox + "%')";
                    break;
            }

            // ds = Datos.EjecutarCualquierQuerys("SELECT * FROM Productos where Nombre_Producto like ('" + textbox + "%')");

            ds = Datos.EjecutarCualquierQuerys(query);


            return ds;

        }
    }
}
