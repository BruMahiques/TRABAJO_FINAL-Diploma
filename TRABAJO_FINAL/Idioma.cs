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
    public partial class Idioma : Form, InterfazIdiomaObserver
    {
        public Idioma()
        {
            InitializeComponent();
            Traducir();
        }
        public List<EEIdioma> Idiomas;
        private EE.EEIdioma Idioma1 = new EEIdioma();
        public void TraerIdiomas()
        {
            Idiomas = new List<EEIdioma>();
            Idiomas = BLLIdiomaTraductor.ObtenerIdiomas();

            foreach (var item in Idiomas)

            {
                if (item.Por_Defecto == true)
                    IdiomaDefecto.Text = item.Idioma;
            }

            comboBox1.DataSource = Idiomas;
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

                    if (button2.Tag != null && Traducciones.ContainsKey(button2.Tag.ToString()))
                        button2.Text = Traducciones[button2.Tag.ToString()].Texto;

                    if (button3.Tag != null && Traducciones.ContainsKey(button3.Tag.ToString()))
                        button3.Text = Traducciones[button3.Tag.ToString()].Texto;

                    if (button1.Tag != null && Traducciones.ContainsKey(button1.Tag.ToString()))
                        button1.Text = Traducciones[button1.Tag.ToString()].Texto;

                    if (label1.Tag != null && Traducciones.ContainsKey(label1.Tag.ToString()))
                        label1.Text = Traducciones[label1.Tag.ToString()].Texto;

                    if (label2.Tag != null && Traducciones.ContainsKey(label2.Tag.ToString()))
                        label2.Text = Traducciones[label2.Tag.ToString()].Texto;

                    if (label4.Tag != null && Traducciones.ContainsKey(label4.Tag.ToString()))
                        label4.Text = Traducciones[label4.Tag.ToString()].Texto;

                    if (label3.Tag != null && Traducciones.ContainsKey(label3.Tag.ToString()))
                        label3.Text = Traducciones[label3.Tag.ToString()].Texto;

                    if (checkBoxDefault.Tag != null && Traducciones.ContainsKey(checkBoxDefault.Tag.ToString()))
                        checkBoxDefault.Text = Traducciones[checkBoxDefault.Tag.ToString()].Texto;

                    if (label5.Tag != null && Traducciones.ContainsKey(label5.Tag.ToString()))
                        label5.Text = Traducciones[label5.Tag.ToString()].Texto;

                }

            }

        }

        public void LimpiarControles()

        {
            textcodIdioma.Text = "[...]";
            textDescripIdioma.Text = "";
            checkBoxDefault.Checked = false;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            EEIdioma Idioma = new EEIdioma();
            Idioma = (EEIdioma)comboBox1.SelectedItem;

            textcodIdioma.Text = Convert.ToString(Idioma.Cod_Idioma);
            textDescripIdioma.Text = Idioma.Idioma;
            checkBoxDefault.Checked = Idioma.Por_Defecto;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EEIdioma Idioma = new EEIdioma();
            Idioma = (EEIdioma)comboBox1.SelectedItem;

            DialogResult dialogResult = MessageBox.Show("Seguro que quiere eliminar el Idioma" + " " + Idioma.Idioma + "? Todas las traducciones desapareceran con el idioma", "Eliminar", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
               BLLIdiomaTraductor.EliminarIdioma(Idioma);
                LimpiarControles();
                TraerIdiomas();
            }
            else if (dialogResult == DialogResult.No)
            {
                // Sin resultados
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Idioma1.Idioma = textDescripIdioma.Text;

            if (textcodIdioma.Text == "[...]")

            {
                BLLIdiomaTraductor.Insetaridioma(Idioma1, checkBoxDefault.Checked);
            }

            else

            {
                Idioma1.Cod_Idioma = Convert.ToInt32(textcodIdioma.Text);
                BLLIdiomaTraductor.EditarIdioma(Idioma1, checkBoxDefault.Checked);
            }

            LimpiarControles();
            TraerIdiomas();
        }

        private void Idioma_Load(object sender, EventArgs e)
        {
            ObtenerIdiomas();
            Singleton.Instancia.SuscribirObs(this);

            var bounds = Screen.FromControl(this).Bounds;
            this.Width = bounds.Width - 5;
            this.Height = bounds.Height - 110;
        }
        private void Idioma_FormClosing(object sender, FormClosingEventArgs e)
        {
            Singleton.Instancia.DesuscribirObs(this);
        }
        public void ObtenerIdiomas()
        {
            Idiomas = new List<EEIdioma>();
            Idiomas = BLLIdiomaTraductor.ObtenerIdiomas();

            foreach (var item in Idiomas)

            {
                if (item.Por_Defecto == true)
                    IdiomaDefecto.Text = item.Idioma;
            }

            comboBox1.DataSource = Idiomas;
        }
    }
}
