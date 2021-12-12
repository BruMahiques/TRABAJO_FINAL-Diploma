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
using EE;

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

            Informe1 = BLLVentaDet.CargarGrafico(1, null, null);

            chart1.Titles.Add("Productos Vendidos");

            foreach (DataRow row in Informe1.Rows)
            {
                Series series = chart1.Series.Add(row["Nombre_Producto"].ToString());
                series.Points.Add(Convert.ToInt32(row["Cantidad vendida del producto"].ToString()));
                series.Label = row["Nombre_Producto"].ToString();
            }
            dgvInforme1.DataSource = Informe1;

            Informe2 = BLLVentaDet.CargarGrafico(2, null, null);

            chart2.Titles.Add("Ganancias por Producto");

            foreach (DataRow row in Informe2.Rows)
            {
                Series series = chart2.Series.Add(row["Nombre_Producto"].ToString());
                series.Points.Add(Convert.ToInt32(row["Total"].ToString()));
                series.Label = row["Total"].ToString();
            }
            dgvInforme2.DataSource = Informe2;

            
        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            string desde = dateTimeDesde.Value.ToString("yyyy-MM-dd");
            string hasta = dateTimeHasta.Value.ToString("yyyy-MM-dd");

            SaveFileDialog fileDialog = new SaveFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = fileDialog.FileName;
                Document doc = new Document();
                PdfWriter.GetInstance(doc, new FileStream(path+".pdf", FileMode.Create));
                doc.Open();

                Paragraph title = new Paragraph(string.Format("Informe ventas"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 20, iTextSharp.text.Font.BOLD));
                title.Alignment = Element.ALIGN_CENTER;
                doc.Add(title);
                Paragraph enter = new Paragraph(" ");
                doc.Add(enter);

                PdfPTable pdfTable = new PdfPTable(dgvInforme1.Columns.Count); //Tabla del informe 1
                pdfTable.DefaultCell.Padding = 3;
                pdfTable.WidthPercentage = 100;
                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                foreach (DataGridViewColumn column in dgvInforme1.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    pdfTable.AddCell(cell);
                }

                foreach (DataGridViewRow row in dgvInforme1.Rows)
                {
                    if (row.Cells[index: 0].Value != null)
                    { 
                    foreach (DataGridViewCell cell in row.Cells)
                         {


                        pdfTable.AddCell(cell.Value.ToString());


                         }
                    }

                }

                doc.Add(pdfTable);

                
                doc.Add(enter);
                doc.Add(enter);
                doc.Add(enter);

                Paragraph p1 = new Paragraph("Se puede observar en el siguiente grafico la cantidad de ventas que tuvieron todos los productos de la empresa entre las fechas:  ");
                Paragraph p1p1 = new Paragraph("Desde: "+ desde +"    "+ "Hasta: " + hasta + "    ");
                doc.Add(p1);
                doc.Add(p1p1);
                doc.Add(enter);


                chart1.SaveImage(path + "chart1.png", ChartImageFormat.Png);
                iTextSharp.text.Image image1 = iTextSharp.text.Image.GetInstance(path + "chart1.png");
                doc.Add(image1);

                doc.Add(enter);
                doc.Add(enter);
                doc.Add(enter);
                doc.Add(enter);
                doc.Add(enter);
                doc.Add(enter);
                doc.Add(enter);
                doc.Add(enter);
                doc.Add(enter);
                doc.Add(enter);
                doc.Add(enter);
                doc.Add(enter);
                doc.Add(enter);
                doc.Add(enter);
                doc.Add(enter);

                PdfPTable pdfTable2 = new PdfPTable(dgvInforme2.Columns.Count); //Tabla del informe 2
                pdfTable2.DefaultCell.Padding = 3;
                pdfTable2.WidthPercentage = 100;
                pdfTable2.HorizontalAlignment = Element.ALIGN_LEFT;
                foreach (DataGridViewColumn column in dgvInforme2.Columns)
                {
                    PdfPCell cell2 = new PdfPCell(new Phrase(column.HeaderText));
                    pdfTable2.AddCell(cell2);
                }

                foreach (DataGridViewRow row in dgvInforme2.Rows)
                {
                    if (row.Cells[index: 0].Value != null)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {


                            pdfTable2.AddCell(cell.Value.ToString());


                        }
                    }

                }
                doc.Add(pdfTable2);

                doc.Add(enter);
                doc.Add(enter);
                doc.Add(enter);

                Paragraph p2 = new Paragraph("Se puede obnservar en el siguiente grafico las ganancias que tuvo la empresa por venta de los productos entre las fechas: ");
                Paragraph p2p2 = new Paragraph("Desde: " + desde + "    " + "Hasta: " + hasta + "    ");
                doc.Add(p2);
                doc.Add(p2p2);
                doc.Add(enter);
                chart2.SaveImage(path + "chart2.png", ChartImageFormat.Png);
                iTextSharp.text.Image image2 = iTextSharp.text.Image.GetInstance(path + "chart2.png");
                doc.Add(image2);

                doc.Close();

                btnCargarDatos.Enabled = false;
            

            }
        }

        private void Filtrar_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            chart2.Series.Clear();
            dgvInforme1.DataSource = null;
            dgvInforme2.DataSource = null;

            DataTable Informe1;
            DataTable Informe2;

            string desde = dateTimeDesde.Value.ToString("yyyy-MM-dd");
            string hasta = dateTimeHasta.Value.ToString("yyyy-MM-dd");

            Informe1 = BLLVentaDet.CargarGrafico(3, desde, hasta);

            //chart1.Titles.Add("Productos Vendidos");

            foreach (DataRow row in Informe1.Rows)
            {
                Series series = chart1.Series.Add(row["Nombre_Producto"].ToString());
                series.Points.Add(Convert.ToInt32(row["Cantidad vendida del producto"].ToString()));
                series.Label = row["Nombre_Producto"].ToString();
            }
            dgvInforme1.DataSource = Informe1;

            Informe2 = BLLVentaDet.CargarGrafico(4, desde, hasta);

            //chart2.Titles.Add("Ganancias por Producto");

            foreach (DataRow row in Informe2.Rows)
            {
                Series series = chart2.Series.Add(row["Nombre_Producto"].ToString());
                series.Points.Add(Convert.ToInt32(row["Total"].ToString()));
                series.Label = row["Total"].ToString();
            }
            dgvInforme2.DataSource = Informe2;
            btnCargarDatos.Enabled = true;
            
        }

       
    }
}
