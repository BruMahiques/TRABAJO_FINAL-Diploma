using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace Datos
{
    public class Acceso
    {
        private SqlConnection Conexion;
        private SqlCommand ComandoSQL;
        private SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DVP7934\SQLEXPRESS;Initial Catalog=JUEGOMES;Integrated Security=True");
        private SqlTransaction transaction;
        private SqlTransaction Transaction;
        private SqlCommand cmd;
        private string CadenaConexion = @"Data Source=DESKTOP-DVP7934\SQLEXPRESS;Initial Catalog=JUEGOMES;Integrated Security=True";

        public void Abrir()
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-DVP7934\SQLEXPRESS;Initial Catalog=JUEGOMES;Integrated Security=True";
            con.Open();
        }

        public void Cerrar()
        {
            con.Close();
            con.Dispose();
            con = null;
            GC.Collect();
        }

        private SqlConnection AbrirConexion()

        {
            Conexion = new SqlConnection(CadenaConexion);
            Conexion.Open();
            return Conexion;
        }

        public DataSet Leer(string consulta, Hashtable Hdatos)
        {
            DataSet ds = new DataSet();
            cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = consulta;
            cmd.CommandType = CommandType.StoredProcedure;

            
            if (Hdatos != null)
            {
                foreach (string d in Hdatos.Keys)
                {
                    cmd.Parameters.AddWithValue(d, Hdatos[d]);
                }


            }
            SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
            Adapter.Fill(ds);

            return ds;

        }


     

        public bool Escribir(string Consulta, Hashtable Hdatos)
        {
            Abrir();

            try
            {
                transaction = con.BeginTransaction();
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = Consulta;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Transaction = transaction;

                if (Hdatos != null)
                {
                    foreach (string d in Hdatos.Keys)
                    {
                        cmd.Parameters.AddWithValue(d, Hdatos[d]);
                    }
                }

                int a = cmd.ExecuteNonQuery();
                transaction.Commit();
                return true;


            }
            catch
            {


                transaction.Rollback();
                return false;
            }
            finally
            {
                Cerrar();
            }
        }

        public string EscribirUsu(string Consulta, Hashtable Parametros)
        {
            ComandoSQL = new SqlCommand();
            ComandoSQL.Connection = AbrirConexion();

            string Id = ""; // Valor que se capturará en el caso de insersiones

            try
            {

                Transaction = Conexion.BeginTransaction();
                ComandoSQL.CommandText = Consulta;
                ComandoSQL.CommandType = CommandType.StoredProcedure;
                ComandoSQL.Transaction = Transaction;


                if ((Parametros != null))
                {
                    foreach (string dato in Parametros.Keys)
                    {
                        ComandoSQL.Parameters.AddWithValue(dato, Parametros[dato]);
                    }
                }
                ComandoSQL.Parameters.Add("@Id_ins", SqlDbType.Int).Direction = ParameterDirection.Output; // Para inserción

                int respuesta = ComandoSQL.ExecuteNonQuery();
                Transaction.Commit();
                Id = ComandoSQL.Parameters["@Id_ins"].Value.ToString().Trim();
            }

            catch (Exception ex)
            {

                Transaction.Rollback();
                throw new Exception(ex.Message);
            }

            finally
            {
                Conexion.Close();
            }
            return Id;
        }

        public void EjecutarQuerysBackup(string Consulta) // Exclusivo para tareas de backup: se conecta a la base MASTER y no utiliza Transacciones
        {
            ComandoSQL = new SqlCommand();
            Conexion = new SqlConnection(@"Data Source=DESKTOP-DVP7934\SQLEXPRESS;Initial Catalog=JUEGOMES;Integrated Security=True");
            Conexion.Open();
            ComandoSQL.Connection = Conexion;

            try
            {
                ComandoSQL.CommandText = Consulta;
                ComandoSQL.CommandTimeout = 600;
                ComandoSQL.CommandType = CommandType.Text;
                ComandoSQL.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Conexion.Close();
            }
        }

        public DataTable EjecutarCualquierQuerys(string Consulta) 
        {
            
            ComandoSQL = new SqlCommand();
            Conexion = new SqlConnection(@"Data Source=DESKTOP-DVP7934\SQLEXPRESS;Initial Catalog=JUEGOMES;Integrated Security=True");
            Conexion.Open();
            ComandoSQL.Connection = Conexion;

            try
            {
                ComandoSQL.CommandText = Consulta;
                ComandoSQL.CommandTimeout = 600;
                ComandoSQL.CommandType = CommandType.Text;
                ComandoSQL.ExecuteNonQuery();

             
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Conexion.Close();
                                                
            }

            DataTable dt = new DataTable();
            SqlDataAdapter Adapter = new SqlDataAdapter(ComandoSQL);
            Adapter.Fill(dt);

            return dt;


        }


    }
}
