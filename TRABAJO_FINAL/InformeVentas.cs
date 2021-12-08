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
using System.Windows.Forms.DataVisualization.Charting;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace TRABAJO_FINAL
{
    public partial class InformeVentas : Form
    {
        public InformeVentas()
        {
            InitializeComponent();
        }

        BLLVentaDet BLLVentaDet = new BLLVentaDet();
        private void InformeVentas_Load(object sender, EventArgs e)
        {
            CargarInformeVentas();
        }

        public void CargarInformeVentas()
        {
            DataTable Informe1;
            DataTable Informe2;

            Informe1 = BLLVentaDet.CargarGrafico(1);

            chart1.Titles.Add("Productos Vendidos");

            foreach (DataRow row in Informe1.Rows)
            {
                Series series = chart1.Series.Add(row["Nombre_Producto"].ToString());
                series.Points.Add(Convert.ToInt32(row["Cantidad vendida del producto"].ToString()));
                series.Label = row["Nombre_Producto"].ToString();
            }

            Informe2 = BLLVentaDet.CargarGrafico(2);

            chart2.Titles.Add("Ganancias por Producto");

            foreach (DataRow row in Informe2.Rows)
            {
                Series series = chart2.Series.Add(row["Nombre_Producto"].ToString());
                series.Points.Add(Convert.ToInt32(row["Total"].ToString()));
                series.Label = row["Total"].ToString();
            }
        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog fileDialog = new SaveFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = fileDialog.FileName;
                Document doc = new Document();
                PdfWriter.GetInstance(doc, new FileStream(path+".pdf", FileMode.Create));
                doc.Open();
                
                Paragraph p1 = new Paragraph("Texto");
                doc.Add(p1);

                chart1.SaveImage(path + "chart1.png", ChartImageFormat.Png);
                iTextSharp.text.Image image1 = iTextSharp.text.Image.GetInstance(path + "chart1.png");
                doc.Add(image1);

                Paragraph p2 = new Paragraph("Texto 2");
                doc.Add(p2);

                chart2.SaveImage(path + "chart2.png", ChartImageFormat.Png);
                iTextSharp.text.Image image2 = iTextSharp.text.Image.GetInstance(path + "chart2.png");
                doc.Add(image2);

                doc.Close();

            }
        }
    }
}
