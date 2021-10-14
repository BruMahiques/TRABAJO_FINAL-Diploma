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
    public partial class Idioma : Form
    {
        public Idioma()
        {
            InitializeComponent();
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
