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

namespace TRABAJO_FINAL
{
    public partial class IdiomaTraducciones : Form
    {
        public IdiomaTraducciones()
        {
            InitializeComponent();
        }


        private BLL.BLLIdiomaTitulo BLLTitulo = new BLLIdiomaTitulo();

        private EE.EEIdioma EEIdioma = new EEIdioma();
        private EE.EEIdiomaTitulo EETitulo = new EEIdiomaTitulo();

        private void IdiomaTraducciones_Load(object sender, EventArgs e)
        {
            comboTitulo.DataSource = BLLTitulo.ObtenerEtiquetas();
            comboIdioma.DataSource = BLLIdiomaTraductor.ObtenerIdiomas();
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
