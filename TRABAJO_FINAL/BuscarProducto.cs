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
    public partial class BuscarProducto : Form
    {
        public BuscarProducto()
        {
            InitializeComponent();
        }

        private void BuscarProducto_Load(object sender, EventArgs e)
        {
            ObtenerProductos();
            rbNombreProd.Checked = true;
        }

        BLLProducto BLLProducto = new BLLProducto();

        private void ObtenerProductos()
        {
            List<EEProducto> productos = BLLProducto.ListarProductos();

            dgvProductos.DataSource = null;
            dgvProductos.DataSource = productos;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            ObtenerProductos();
        }

        private void Filtrar_Click(object sender, EventArgs e)
        {
            if (rbNombreProd.Checked == true)
            {
                DataTable productos = BLLProducto.ListarProductosFiltrado(txtBusqProd.Text, 1);
                dgvProductos.DataSource = null;
                dgvProductos.DataSource = productos;
            }
            else {
                if (rbCategoria.Checked == true)
                {
                    DataTable productos = BLLProducto.ListarProductosFiltrado(txtBusqProd.Text, 2);
                    dgvProductos.DataSource = null;
                    dgvProductos.DataSource = productos;
                }
                else {
                    if (rbPrecio.Checked == true)
                    {
                        DataTable productos = BLLProducto.ListarProductosFiltrado(txtBusqProd.Text, 3);
                        dgvProductos.DataSource = null;
                        dgvProductos.DataSource = productos;
                    }
                    else
                    {
                        DataTable productos = BLLProducto.ListarProductosFiltrado(txtBusqProd.Text, 4);
                        dgvProductos.DataSource = null;
                        dgvProductos.DataSource = productos;
                    }
                     }
                }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
