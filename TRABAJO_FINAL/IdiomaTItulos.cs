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
    public partial class IdiomaTitulos : Form , InterfazIdiomaObserver
    {
        public IdiomaTitulos()
        {
            InitializeComponent();
            Traducir();
        }

        private BLL.BLLIdiomaTitulo BLLIdiomaTitu = new BLLIdiomaTitulo();
        private EE.EEIdiomaTitulo EEIdiomaTitu = new EEIdiomaTitulo();

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

                   
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EEIdiomaTitu.Cod_Titulo = 0;
            EEIdiomaTitu.Descripcion = TxtTitulo.Text;
            BLLIdiomaTitu.abmEtiqueta(EEIdiomaTitu, 1);
            CargarGrid();
            LimpiarControles();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EEIdiomaTitu.Cod_Titulo = Convert.ToInt32(TxtCodTitulo.Text);
            EEIdiomaTitu.Descripcion = TxtTitulo.Text;
            BLLIdiomaTitu.abmEtiqueta(EEIdiomaTitu, 2);
            CargarGrid();
            LimpiarControles();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Usted va a eliminar el título seleccionado?", "Eliminar", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                EEIdiomaTitu.Cod_Titulo = Convert.ToInt32(TxtCodTitulo.Text);
                BLLIdiomaTitu.abmEtiqueta(EEIdiomaTitu, 3);
                CargarGrid();
                LimpiarControles();
            }
            else if (dialogResult == DialogResult.No)
            {
                // No hago nada
            }
        }     

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtCodTitulo.Text = Convert.ToString(dataGridViewTitulos.Rows[e.RowIndex].Cells[0].Value);
            TxtTitulo.Text = Convert.ToString(dataGridViewTitulos.Rows[e.RowIndex].Cells[1].Value);
        }
        public void LimpiarControles()
        {
            TxtCodTitulo.Text = "0";
            TxtTitulo.Text = "";

        }        
        private void IdiomaTitulos_Load(object sender, EventArgs e)
        {
            CargarGrid();
            Singleton.Instancia.SuscribirObs(this);
        }
        private void IdiomaTitulos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Singleton.Instancia.DesuscribirObs(this);
        }
        public void CargarGrid()

        {
            dataGridViewTitulos.DataSource = null;
            dataGridViewTitulos.DataSource = BLLIdiomaTitu.ObtenerEtiquetas();
        }
    }
}
