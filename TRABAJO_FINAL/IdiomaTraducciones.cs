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
    public partial class IdiomaTraducciones : Form , InterfazIdiomaObserver
    {
        public IdiomaTraducciones()
        {
            InitializeComponent();
            Traducir();
        }


        private BLL.BLLIdiomaTitulo BLLTitulo = new BLLIdiomaTitulo();

        private EE.EEIdioma EEIdioma = new EEIdioma();
        private EE.EEIdiomaTitulo EETitulo = new EEIdiomaTitulo();

        private void IdiomaTraducciones_Load(object sender, EventArgs e)
        {
            comboTitulo.DataSource = BLLTitulo.ObtenerEtiquetas();
            comboIdioma.DataSource = BLLIdiomaTraductor.ObtenerIdiomas();
            Singleton.Instancia.SuscribirObs(this);
        }
        private void IdiomaTraducciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            Singleton.Instancia.DesuscribirObs(this);
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

                    if (button1.Tag != null && Traducciones.ContainsKey(button1.Tag.ToString()))
                        button1.Text = Traducciones[button1.Tag.ToString()].Texto;

                    if (label1.Tag != null && Traducciones.ContainsKey(label1.Tag.ToString()))
                        label1.Text = Traducciones[label1.Tag.ToString()].Texto;

                    if (label2.Tag != null && Traducciones.ContainsKey(label2.Tag.ToString()))
                        label2.Text = Traducciones[label2.Tag.ToString()].Texto;

                    if (label3.Tag != null && Traducciones.ContainsKey(label3.Tag.ToString()))
                        label3.Text = Traducciones[label3.Tag.ToString()].Texto;

                    

                }

            }

        }


        private void button1_Click(object sender, EventArgs e)
        {

            LeerCombos();
            var Traducciones = BLLIdiomaTraductor.ObtenerTraducciones(EEIdioma);

            if (Traducciones == null)  // Traducciones va a ser null cuando se cree un idioma nuevo y no tenga traducciones cargadas para los titulos
            {
                MessageBox.Show("No existen la traducción para el Idioma seleccionado");
                textTraduccion.Text = "";
            }

            else
            {
                if (Traducciones.ContainsKey(EETitulo.Descripcion))

                {
                    textTraduccion.Text = Traducciones[EETitulo.Descripcion].Texto;
                }

                else

                {
                    MessageBox.Show("No existen la traducción para el Idioma seleccionado");
                    textTraduccion.Text = "";
                }

                Traducciones.Clear();
                Traducciones = BLLIdiomaTraductor.ObtenerTraducciones(EEIdioma);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LeerCombos();
            var Traducciones = BLLIdiomaTraductor.ObtenerTraducciones(EEIdioma);
            EEIdiomaTraduccion Traduccion = new EEIdiomaTraduccion();
            Traduccion.Titulo = EETitulo;
            Traduccion.Texto = textTraduccion.Text;

            if (Traducciones != null && Traducciones.ContainsKey(EETitulo.Descripcion)) // Si existe traduccion entonces la modifico

            {
                BLLIdiomaTraductor.InsertarEditarTraduccion(EEIdioma, Traduccion, 2);
                MessageBox.Show("Se modifico la traducción correctamente");
            }

            else

            {
                BLLIdiomaTraductor.InsertarEditarTraduccion(EEIdioma, Traduccion, 1); // Si no existe traduccion entonces la creo
                MessageBox.Show("Se creó la traducción correctamente");
            }

            textTraduccion.Text = "";
        }

        public void LeerCombos()
        {
            EETitulo = (EEIdiomaTitulo)comboTitulo.SelectedItem;
            EEIdioma = (EEIdioma)comboIdioma.SelectedItem;
        }

       
    }
}
