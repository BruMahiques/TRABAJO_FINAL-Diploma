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
    public partial class AyudaAdmin : Form, InterfazIdiomaObserver
    {
        public AyudaAdmin()
        {
            InitializeComponent();
            Traducir();
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
          
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

                    if (button8.Tag != null && Traducciones.ContainsKey(button8.Tag.ToString()))
                        button8.Text = Traducciones[button8.Tag.ToString()].Texto;

                    if (button1.Tag != null && Traducciones.ContainsKey(button1.Tag.ToString()))
                        button1.Text = Traducciones[button1.Tag.ToString()].Texto;

                    if (button2.Tag != null && Traducciones.ContainsKey(button2.Tag.ToString()))
                        button2.Text = Traducciones[button2.Tag.ToString()].Texto;

                    if (button3.Tag != null && Traducciones.ContainsKey(button3.Tag.ToString()))
                        button3.Text = Traducciones[button3.Tag.ToString()].Texto;

                    if (button4.Tag != null && Traducciones.ContainsKey(button4.Tag.ToString()))
                        button4.Text = Traducciones[button4.Tag.ToString()].Texto;

                    if (button5.Tag != null && Traducciones.ContainsKey(button5.Tag.ToString()))
                        button5.Text = Traducciones[button5.Tag.ToString()].Texto;

                    if (button6.Tag != null && Traducciones.ContainsKey(button6.Tag.ToString()))
                        button6.Text = Traducciones[button6.Tag.ToString()].Texto;

                    if (button7.Tag != null && Traducciones.ContainsKey(button7.Tag.ToString()))
                        button7.Text = Traducciones[button7.Tag.ToString()].Texto;

                    if (button8.Tag != null && Traducciones.ContainsKey(button8.Tag.ToString()))
                        button8.Text = Traducciones[button8.Tag.ToString()].Texto;

                    if (button9.Tag != null && Traducciones.ContainsKey(button9.Tag.ToString()))
                        button9.Text = Traducciones[button9.Tag.ToString()].Texto;

                    if (button10.Tag != null && Traducciones.ContainsKey(button10.Tag.ToString()))
                        button10.Text = Traducciones[button10.Tag.ToString()].Texto;

                    if (button11.Tag != null && Traducciones.ContainsKey(button11.Tag.ToString()))
                        button11.Text = Traducciones[button11.Tag.ToString()].Texto;

                    if (button12.Tag != null && Traducciones.ContainsKey(button12.Tag.ToString()))
                        button12.Text = Traducciones[button12.Tag.ToString()].Texto;

                }


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = true;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = true;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = true;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = true;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = true;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = true;
            pictureBox10.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = true;
        }

        private void AyudaAdmin_Load(object sender, EventArgs e)
        {
            Singleton.Instancia.SuscribirObs(this);
        }
        private void AyudaAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Singleton.Instancia.DesuscribirObs(this);
        }
    }
}
