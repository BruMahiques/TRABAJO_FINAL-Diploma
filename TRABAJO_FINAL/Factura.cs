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
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            try
            {

                //CrearGrid();
                ContarItems();
               // txtCodUsuario.Text = us.Codigo_Usuario;
                CargarSerie_correlativo();
                btnAnular.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ContarItems()
        {
            try
            {
                int num = 0;
                foreach (DataGridViewRow row in dgvDetalleBoleta.Rows)
                {
                    num++;
                }
                lblNumItems.Text = "Nº Items:  " + num;
            }
            catch (Exception)
            {

                throw;
            }
        }
       /* private void CrearGrid()
        {
            try
            {
                dgvDetalleBoleta.Columns.Add("ColumnIdProd", "Idprod");
                dgvDetalleBoleta.Columns.Add("ColumnNombreProd", "Producto");
                dgvDetalleBoleta.Columns.Add("ColumnCantidad", "Cantidad");
                dgvDetalleBoleta.Columns.Add("ColumnPrecio", "Precio");
                dgvDetalleBoleta.Columns.Add("ColumnTotal", "Total");

                dgvDetalleBoleta.Columns[0].Visible = false;
                dgvDetalleBoleta.Columns[1].Width = 315;
                dgvDetalleBoleta.Columns[2].Width = 70;
                dgvDetalleBoleta.Columns[3].Width = 70;
                dgvDetalleBoleta.Columns[4].Width = 70;

                dgvDetalleBoleta.Columns[1].ReadOnly = true;
                dgvDetalleBoleta.Columns[2].ReadOnly = false;
                dgvDetalleBoleta.Columns[3].ReadOnly = false;
                dgvDetalleBoleta.Columns[4].ReadOnly = true;

                dgvDetalleBoleta.Columns[4].DefaultCellStyle.BackColor = Color.GreenYellow;

                DataGridViewCellStyle cssabecera = new DataGridViewCellStyle();
                cssabecera.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvDetalleBoleta.ColumnHeadersDefaultCellStyle = cssabecera;

                dgvDetalleBoleta.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
                dgvDetalleBoleta.DefaultCellStyle.Font = new Font("Arial", 9);


                dgvDetalleBoleta.AllowUserToAddRows = false;
                dgvDetalleBoleta.MultiSelect = false;
                dgvDetalleBoleta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            }
            catch (Exception)
            {

                throw;
            }
        }
        */
        private void CargarSerie_correlativo()
        {
           
        }
    }
}
