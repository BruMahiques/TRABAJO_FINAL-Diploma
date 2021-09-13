using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRABAJO_FINAL
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void aBMCLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMClienteConectado F1 = new ABMClienteConectado();
            F1.MdiParent = this;
            F1.Show();
        }

        private void aBMProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductoDesconectado F2 = new ProductoDesconectado();
            F2.MdiParent = this;
            F2.Show();
        }

        private void ReservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reservas F3 = new Reservas();
            F3.MdiParent = this;
            F3.Show();
        }

        

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte_Consultas F5 = new Reporte_Consultas();
            F5.MdiParent = this;
            F5.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void compositeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Componente F5 = new Componente();
            F5.MdiParent = this;
            F5.Show();
        }

        private void idiomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Idioma F5 = new Idioma();
            F5.MdiParent = this;
            F5.Show();
        }

        private void titulosDeIdiomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IdiomaTitulos F5 = new IdiomaTitulos();
            F5.MdiParent = this;
            F5.Show();
        }

        private void traduccionesDeIdiomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IdiomaTraducciones F5 = new IdiomaTraducciones();
            F5.MdiParent = this;
            F5.Show();
        }
    }
}
