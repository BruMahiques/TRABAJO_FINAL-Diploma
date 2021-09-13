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
    public partial class IdiomaTitulos : Form
    {
        public IdiomaTitulos()
        {
            InitializeComponent();
        }

        private BLL.BLLIdiomaTitulo BLLIdiomaTitu = new BLLIdiomaTitulo();
        private EE.EEIdiomaTitulo EEIdiomaTitu = new EEIdiomaTitulo();

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
        }
        public void CargarGrid()

        {
            dataGridViewTitulos.DataSource = null;
            dataGridViewTitulos.DataSource = BLLIdiomaTitu.ObtenerEtiquetas();
        }
    }
}
