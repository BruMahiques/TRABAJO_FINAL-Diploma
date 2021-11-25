using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using System.Data;

namespace TRABAJO_FINAL
{
    public partial class Reporte_Consultas : Form
    {
        public Reporte_Consultas()
        {
            InitializeComponent();
            
        }

        DataSet ds = new DataSet();
        BLLReportes oBLLReporte = new BLLReportes();

        private void btnReporteA_Click(object sender, EventArgs e)
        {
            ds = oBLLReporte.ReporteA();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ds = oBLLReporte.ReporteB();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnReporteC_Click(object sender, EventArgs e)
        {
            ds = oBLLReporte.ReporteC();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ds.Tables[0];
        }
        /*void CambiarIdiomaEspañol(string Cultura)
        {

            label1.Text = Resource1.Consultas;
            label3.Text = Resource1.DNI_Cliente;
            
            label2.Text = Resource1.Dias;
            btnReporteA.Text = Resource1.btnReporteA;
            button5.Text = Resource1.Salir;
            btnReporteC.Text = Resource1.btnReporteB;



        }
        void CambiarIdiomaIngles(string Cultura)
        {
            label1.Text = Resource2.Consultas;
            label3.Text = Resource2.DNI_Cliente;
            
            label2.Text = Resource2.Dias;
            btnReporteA.Text = Resource2.btnReporteA;
            button5.Text = Resource2.Salir;
            btnReporteC.Text = Resource2.btnReporteB;



        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            CambiarIdiomaEspañol("Resource1");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            CambiarIdiomaIngles("Resource2");
        }
        */
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
