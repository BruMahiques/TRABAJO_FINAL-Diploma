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
using BLL;
using System.Collections;
using SERVICIOS;

namespace TRABAJO_FINAL
{
    public partial class InicioSesion : Form, InterfazIdiomaObserver
    {
        public InicioSesion()
        {
            InitializeComponent();
            Traducir();
        }

        public void UpdateLanguage(EEIdioma idioma)
        {
            Traducir();
        }

        private SERVICIOS.Bitacora.BitacoraBLL bllAct = new SERVICIOS.Bitacora.BitacoraBLL();


        private void Traducir()

        {
            EEIdioma Idioma = null;

            if (Singleton.Instancia.Estalogueado()) Idioma = Singleton.Instancia.Usuario.Idioma;

            var Traducciones = BLLIdiomaTraductor.ObtenerTraducciones(Idioma);

            if (Traducciones != null) // Al crear un idioma nuevo y utilizarlo no habrá traducciones, por lo tanto es necesario consultar si es null
            {
               

                if (this.Tag != null && Traducciones.ContainsKey(this.Tag.ToString()))  // Título del form
                    this.Text = Traducciones[this.Tag.ToString()].Texto;

                foreach (Control x in this.Controls) // Todos los controles

                {
                    if (x.Tag != null && Traducciones.ContainsKey(x.Tag.ToString()))
                        x.Text = Traducciones[x.Tag.ToString()].Texto;

                    if (Sal.Tag != null && Traducciones.ContainsKey(Sal.Tag.ToString()))
                        Sal.Text = Traducciones[Sal.Tag.ToString()].Texto;

                    if (Usu.Tag != null && Traducciones.ContainsKey(Usu.Tag.ToString()))
                        Usu.Text = Traducciones[Usu.Tag.ToString()].Texto;

                    if (Clave.Tag != null && Traducciones.ContainsKey(Clave.Tag.ToString()))
                        Clave.Text = Traducciones[Clave.Tag.ToString()].Texto;

                    if (Entrar.Tag != null && Traducciones.ContainsKey(Entrar.Tag.ToString()))
                        Entrar.Text = Traducciones[Entrar.Tag.ToString()].Texto;

                    if (Sal.Tag != null && Traducciones.ContainsKey(Sal.Tag.ToString()))
                        Sal.Text = Traducciones[Sal.Tag.ToString()].Texto;


                }
               

            }

        }

        
        int count = 0;
        SqlConnection conexion = new SqlConnection();


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
                textBox2.PasswordChar = '*';
            
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
          
            BLLUsuario bllUsuario = new BLLUsuario();


            try
            {
                var Resultado = bllUsuario.Login(textBox1.Text.Trim(), textBox2.Text.Trim());
                
                SERVICIOS.Bitacora.BitacoraActividadTipoEE tipo = new SERVICIOS.Bitacora.BitacoraActividadTipoEE();
                tipo = bllAct.ListarTipos().First(item => item.Tipo == "Mensaje");
                RegistroBitacora("Acceso Exitoso", tipo);
                
                MDI F1 = new MDI();
                F1.Show();
            }

            catch (SERVICIOS.Inicio.ExceptionLogin Error)

            {
                switch (Error.Result)
                {
                    case SERVICIOS.Inicio.ResultadoLogin.UsuarioInvalido:
                        MessageBox.Show("Usuario Incorrecto");

                        break;
                    case SERVICIOS.Inicio.ResultadoLogin.PasswordInvalido:
                        MessageBox.Show("El Password ingresado es Incorrecto");

                        break;

                    default:
                        break;
                }
            }
           



        }

   

        public void RegistroBitacora(string Detalle, SERVICIOS.Bitacora.BitacoraActividadTipoEE Tipo)

        {
            SERVICIOS.Bitacora.BitacoraActividadEE nAct = new SERVICIOS.Bitacora.BitacoraActividadEE();

            nAct.Detalle = Detalle;
            nAct.SetTipo(Tipo);
            bllAct.NuevaActividad(nAct);
        }

        
        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Singleton.Instancia.SuscribirObs(this);
            
        }
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Singleton.Instancia.DesuscribirObs(this);
        }
    }
}
