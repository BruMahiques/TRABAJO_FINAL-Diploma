using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EE;
using BLL;
using SERVICIOS;

namespace TRABAJO_FINAL
{
    public partial class AyudaMenu : Form, InterfazIdiomaObserver
    {
        public AyudaMenu()
        {
            InitializeComponent();
            Traducir();
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
        }
        public void UpdateLanguage(EEIdioma idioma)
        {
            Traducir();
        }
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

                    if (button1.Tag != null && Traducciones.ContainsKey(button1.Tag.ToString()))
                        button1.Text = Traducciones[button1.Tag.ToString()].Texto;

                    if (button2.Tag != null && Traducciones.ContainsKey(button2.Tag.ToString()))
                        button2.Text = Traducciones[button2.Tag.ToString()].Texto;

                    if (button3.Tag != null && Traducciones.ContainsKey(button3.Tag.ToString()))
                        button3.Text = Traducciones[button3.Tag.ToString()].Texto;

                    if (button3.Tag != null && Traducciones.ContainsKey(button3.Tag.ToString()))
                        button3.Text = Traducciones[button3.Tag.ToString()].Texto;


                }


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
            pictureBox4.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = true;
        }

        private void AyudaMenu_Load(object sender, EventArgs e)
        {
            Singleton.Instancia.SuscribirObs(this);
        }
        private void AyudaMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Singleton.Instancia.DesuscribirObs(this);
        }
    }
}
