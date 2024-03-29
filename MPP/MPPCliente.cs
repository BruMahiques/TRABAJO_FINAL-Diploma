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
            Hdatos.Add("@Saldo", EECliente.Saldo);

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
                    EECliente.Apellido = fila["Apellido"].ToString();
                    EECliente.Nombre = fila["Nombre"].ToString();
                    EECliente.DNI = Convert.ToInt32(fila["DNI"]);
                    EECliente.FechaNac = Convert.ToDateTime(fila["FechaNac"]);
                    EECliente.Correo = fila["Correo"].ToString();
                    EECliente.Saldo = Convert.ToSingle(fila["Saldo"]);
                    LClientes.Add(EECliente);

                }
            }

            return LClientes;

        }
        public List<EEClienteVersionado> ListarClienteVersionado()
        {
            Acceso Datos = new Acceso();
            DataSet ds = new DataSet();

            List<EEClienteVersionado> LClientes = new List<EEClienteVersionado>();

            ds = Datos.Leer("SP_ClienteVersionado_Listar", null);

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in ds.Tables[0].Rows)
                {
                    EEClienteVersionado EEClienteVersionado = new EEClienteVersionado();
                    EEClienteVersionado.Cod_Cliente = Convert.ToInt16(fila["Cod_Cliente"]);
                    EEClienteVersionado.Apellido = fila["Apellido"].ToString();
                    EEClienteVersionado.Nombre = fila["Nombre"].ToString();
                    EEClienteVersionado.DNI = Convert.ToInt32(fila["DNI"]);
                    EEClienteVersionado.FechaNac = Convert.ToDateTime(fila["FechaNac"]);
                    EEClienteVersionado.Correo = fila["Correo"].ToString();
                    EEClienteVersionado.Saldo = Convert.ToSingle(fila["Saldo"]);
                    EEClienteVersionado.Start = Convert.ToDateTime(fila["SysStartTime"]);
                    EEClienteVersionado.End = Convert.ToDateTime(fila["SysEndTime"]);
                    LClientes.Add(EEClienteVersionado);

                }
            }

            return LClientes;

        }

        public List<EECliente> ListarClientesFiltrado(string textbox, string textbox2, int num)
        {
            Acceso Datos = new Acceso();
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();

            EECliente Cliente = new EECliente();
            List<EECliente> LCliente = new List<EECliente>();

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

            
            dt = Datos.EjecutarCualquierQuerys(query);
            ds.Tables.Add(dt);

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in ds.Tables[0].Rows)
                {
                    Cliente = MapearCliente(fila);
                    LCliente.Add(Cliente);
                }
            }

            return LCliente;

        }

        public DataTable ListarClientesHistoricoFiltrado(string textbox, string desde, string hasta, int num)
        {
            Acceso Datos = new Acceso();
            DataTable dt = new DataTable();

            string query;

            switch (num)
            {
                case 1:
                    query = "SELECT * FROM ClienteHistory where Cod_Cliente like ('" + textbox + "%') and SysStartTime > ('" + desde + "') and SysEndTime < ('" + hasta + " 23:59:59')";
                    break;
                case 2:
                    query = "SELECT * FROM ClienteHistory where Apellido like ('" + textbox + "%') and SysStartTime > ('" + desde + "') and SysEndTime < ('" + hasta + " 23:59:59')";
                    break;
                case 3:
                    query = "SELECT * FROM ClienteHistory where Nombre like ('" + textbox + "%') and SysStartTime > ('" + desde + "') and SysEndTime < ('" + hasta + " 23:59:59')";
                    break;
                case 4:
                    query = "SELECT * FROM ClienteHistory where DNI like ('" + textbox + "%') and SysStartTime > ('" + desde + "') and SysEndTime < ('" + hasta + " 23:59:59')";
                    break;
                case 5:
                    query = "SELECT * FROM ClienteHistory where Correo like ('" + textbox + "%') and SysStartTime > ('" + desde + "') and SysEndTime < ('" + hasta + " 23:59:59')";
                    break;
                default:
                    query = "SELECT * FROM ClienteHistory";
                    break;
            }



            dt = Datos.EjecutarCualquierQuerys(query);


            return dt;

        }
        public int ExisteCliente(EECliente EECliente)
        {

            Acceso Datos = new Acceso();
            DataTable dt = new DataTable();

            string query;


            query = "SELECT COUNT(1) FROM Cliente WHERE Cod_Cliente = '" + EECliente.Cod_Cliente + "'; ";

            dt = Datos.EjecutarCualquierQuerys(query);

            int num = Convert.ToInt32(dt.Rows[0][0]);

            return num;

        }
        public int ExisteClienteEnComprobante(EECliente EECliente)
        {

            Acceso Datos = new Acceso();
            DataTable dt = new DataTable();

            string query;


            query = "SELECT COUNT(1) FROM Venta WHERE Id_Cliente_Venta = '" + EECliente.Cod_Cliente + "'; ";

            dt = Datos.EjecutarCualquierQuerys(query);

            int num = Convert.ToInt32(dt.Rows[0][0]);

            return num;

        }

        public void RecuperarClientePerdido(EECliente EECliente)
        {

            Acceso Datos = new Acceso();
            DataTable dt = new DataTable();

            string query;

            
            query = "SET IDENTITY_INSERT Cliente ON insert into Cliente(Cod_Cliente, Apellido, Nombre, DNI, FechaNac, Correo) values(" + EECliente.Cod_Cliente + ", '" + EECliente.Apellido + "', '" + EECliente.Nombre + "', " + EECliente.DNI + ", '" + EECliente.FechaNac + "', '" + EECliente.Correo + "') SET IDENTITY_INSERT Cliente OFF";

            dt = Datos.EjecutarCualquierQuerys(query);

            
            

        }
        public EECliente BuscarID(int id)
        {
            Acceso Datos = new Acceso();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            EECliente cliente = null;


            dt = Datos.EjecutarCualquierQuerys("Select * From Cliente Where Cod_Cliente=" + id);

            ds.Tables.Add(dt);

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in ds.Tables[0].Rows)
                {
                    cliente = MapearCliente(fila);

                }

            }



            return cliente;

        }

        private EECliente MapearCliente(DataRow fila)
        {


            var Cliente = new EECliente
            {

                Cod_Cliente = Convert.ToInt32(fila["Cod_Cliente"]),
                Apellido = fila["Apellido"].ToString(),
                Nombre = fila["Nombre"].ToString(),
                DNI = Convert.ToInt32(fila["DNI"].ToString()),
                FechaNac = Convert.ToDateTime(fila["FechaNac"]),
                Correo = fila["Correo"].ToString(),
                Saldo = Convert.ToSingle(fila["Saldo"].ToString()),


            };

            return Cliente;
        }
    }
}
