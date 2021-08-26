using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using System.Data.SqlClient;
using System.Resources;
using System.Globalization;
using System.Threading;
using EE;
using System.Collections;
using System.Data;
using SERVICIOS;

namespace TRABAJO_FINAL
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            radioButton1.Checked = true;
        }
        
       
        

        EEUsuario usuario = new EEUsuario();
        int count = 0;
        SqlConnection conexion = new SqlConnection();


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
                textBox2.PasswordChar = '*';
            
        }

        void CambiarIdiomaEspañol(string Cultura)
        {


            Usu.Text = Resource1.Usu;
            Clave.Text = Resource1.Clave;
            Entrar.Text = Resource1.Entrar;
            button5.Text = Resource1.Salir;
            button1.Text = Resource1.Registrar;

        }
        void CambiarIdiomaIngles(string Cultura)
        {


            Usu.Text = Resource2.Usu;
            Clave.Text = Resource2.Clave;
            Entrar.Text = Resource2.Entrar;
            button5.Text = Resource2.Salir;
            button1.Text = Resource2.Registrar;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            conexion.ConnectionString = @"Data Source=DESKTOP-DVP7934\SQLEXPRESS;Initial Catalog=JUEGOMES;Integrated Security=True";

            SqlCommand cmd = new SqlCommand("Select Usuario, Clave from Usuarios where Usuario ='" + textBox1.Text + "' and Clave='" + textBox2.Text + "'", conexion);
            conexion.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            count++;
            if (count == 4)
            {
                MessageBox.Show("Se bloqueó el programa por internar entrar 3 veces incorrectamente");
                Entrar.Enabled = false;
                return;
            }
            if (dr.Read() == true)
            {
                if (radioButton1.Checked == true)
                {
                    //Singleton
                    SERVICIOS.Singleton s1 = SERVICIOS.Singleton.Instancia;
                    //Singleton
                    MessageBox.Show("Bienvenido " + textBox1.Text);
                    MDI F1 = new MDI();
                    F1.Show();
                }
                else
                {
                    MessageBox.Show("Welcome " + textBox1.Text);
                    MDI F1 = new MDI();
                    F1.Show();
                }

            }


            textBox1.Text = null;
            textBox2.Text = null;


            conexion.Close();





        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            CambiarIdiomaEspañol("Resource1");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            CambiarIdiomaIngles("Resource2");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            usuario.Usuario = textBox1.Text;
            usuario.Clave = textBox2.Text;
            if (textBox1.Text != null && textBox2.Text != null)
            {
                Alta_Usuario(usuario);
            }

        }
        public bool Alta_Usuario(EEUsuario usu)
        {


            Acceso Datos = new Acceso();
            Hashtable Hdatos = new Hashtable();
            bool Resultado;
            string consulta = "SP_Registrar";


            Hdatos.Add("@Usuario", usu.Usuario);
            Hdatos.Add("@Clave", usu.Clave);
           

            Resultado = Datos.Escribir(consulta, Hdatos);
            return Resultado;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
